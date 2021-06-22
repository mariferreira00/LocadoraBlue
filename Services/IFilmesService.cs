using LocadoraDeFilmesPF.Models;
using System.Collections.Generic;

namespace LocadoraDeFilmesPF.Services
{
    public interface IFilmesService  //interface do serviço filmes
    {
        List<Filme> getAll(string busca = null); // lista dos filmes, utilizando o getAll e passando um parametro de busca = null.

        Filme Get(int? id); // crud no banco de dados

        bool Update(Filme f);

        bool Delete(int? id);

        bool Create(Filme f);
    }
}