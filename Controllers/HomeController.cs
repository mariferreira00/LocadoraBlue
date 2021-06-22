using LocadoraDeFilmesPF.Data;
using LocadoraDeFilmesPF.Models;
using LocadoraDeFilmesPF.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraDeFilmesPF.Controllers
{
    public class HomeController : Controller
    {
        IFilmesService _service;
        public HomeController(IFilmesService service)
        {
            _service = service;
        }

        public IActionResult Index1()
        {
            return View();
        }
        public IActionResult Index(string busca = null) => View(_service.getAll(busca));
        [Authorize]
        public IActionResult Create() => View();
        
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Filme filme)
        {
            if (!ModelState.IsValid) return View(filme);


            return _service.Create(filme) ?
                RedirectToAction("Index") :
                NotFound();
        }

        public IActionResult Privacy() => View();

        public IActionResult Visualizar(int? id)
        {
            Filme filme = _service.Get(id);
            return filme == null ? NotFound() : View(filme);
        }

        [Authorize]
        public IActionResult Atualizar(int? id)
        {
            Filme filme = _service.Get(id);
            return filme == null ? NotFound() : View(filme);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Atualizar(Filme filme)
        {
            if (!ModelState.IsValid) return View(filme);

            return _service.Update(filme) ?
                RedirectToAction("Index") :
                NotFound();
        }

        [Authorize]
        public IActionResult Deletar(int? id) =>
            _service.Delete(id) ?
                RedirectToAction("Index") :
                NotFound();
    }
}

