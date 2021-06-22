using LocadoraDeFilmesPF.Models;
using System.Collections.Generic;

namespace LocadoraDeFilmesPF.Services
{
    public interface ILocacoesService
    {
        List<Locacao> getAll(string username, string busca = null);

        Locacao Get(int? id);

        bool Update(Locacao l);

        bool Delete(int? id);

        bool Create(Locacao l, string username);
    }
}