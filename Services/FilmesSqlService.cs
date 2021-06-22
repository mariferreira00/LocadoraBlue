using LocadoraDeFilmesPF.Data;
using LocadoraDeFilmesPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraDeFilmesPF.Services
{
    public class FilmesSqlService : IFilmesService
    {
        private LocadoraContext _context;
        public FilmesSqlService(LocadoraContext context)
        {
            _context = context;
        }

        public bool Create(Filme f)
        {
            try
            {
                _context.Add(f);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int? id)
        {
            try
            {
                _context.Remove(Get(id));
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Filme Get(int? id) => _context.Filme.Find(id);

        public List<Filme> getAll(string busca = null) =>
            _context.Filme.Where(f =>
                busca == null ?
                    true :
                    f.nome.ToUpper().Contains(busca.ToUpper()))
            .ToList();

        public bool Update(Filme f)
        {
            try
            {
                _context.Update(f);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

