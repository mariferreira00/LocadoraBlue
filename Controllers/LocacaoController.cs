using LocadoraDeFilmesPF.Models;
using LocadoraDeFilmesPF.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraDeFilmesPF.Controllers
{
    [Authorize]
    public class LocacaoController : Controller // controllers da locação
    {
        ILocacoesService _service; // Atributo da classe locacaoController, declara a interface IlocacoesService como _service
        IFilmesService _fservice; // Atributo da classe locacaoController, declara a interface IFilmesService como _fservice
        public LocacaoController(ILocacoesService service, IFilmesService fservice)// método da classe locacao controller
        {
            _service = service; // _service anteriormente já declarada como ILocacaoService, agora assume o valor de service, isto é, onde leia-se service, saibamos que a interface está sendo implemetada.
            _fservice = fservice; // _service anteriormente já declarada como IFilmesService, agora assume o valor de fservice, isto é, onde leia-se service, saibamos que a interface está sendo implemetada.
        }

        public IActionResult Index(string busca = null) => View(_service.getAll(User.Identity.Name, busca)); // IA da view index 

        public IActionResult Index1()
        {
            return View();
        }
        public IActionResult Create() // IA da view create
        {
            var filmes = _fservice.getAll();
            ViewBag.listaDeFilmes = new SelectList(filmes, "id", "nome");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Locacao Locacao)
        {
            if (!ModelState.IsValid) // validação do ModelState
            {
                var filmes = _fservice.getAll();
                ViewBag.listaDeFilmes = new SelectList(filmes, "id", "nome");
                return View(Locacao);
            }


            var user = User.Identity.Name;
            return _service.Create(Locacao, user) ?
                RedirectToAction("Index") :
                NotFound();
        }

        public IActionResult Visualizar(int? id)
        {
            Locacao Locacao = _service.Get(id);
            return Locacao == null ? NotFound() : View(Locacao);
        }



        [HttpPost]
        public IActionResult Atualizar(Locacao Locacao)
        {
            if (!ModelState.IsValid) return View(Locacao);

            return _service.Update(Locacao) ?
                RedirectToAction("Index") :
                NotFound();
        }


        public IActionResult Deletar(int? id) =>
            _service.Delete(id) ?
                RedirectToAction("Index") :
                NotFound();
    }

}
