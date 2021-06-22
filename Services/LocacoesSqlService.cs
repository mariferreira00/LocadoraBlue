using LocadoraDeFilmesPF.Data;
using LocadoraDeFilmesPF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraDeFilmesPF.Services
{
    public class LocacoesSqlService : ILocacoesService
    {
        private LocadoraContext _context;
        public LocacoesSqlService(LocadoraContext context)
        {
            _context = context;
        }

        public bool Create(Locacao l, string username)
        {
            try
            {
                var user = _context.Users.FirstOrDefault(u => u.Email == username);
                l.userId = user.Id;
                _context.Add(l);
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

        public Locacao Get(int? id) => _context.Locacao.Include(l => l.Filme).FirstOrDefault(l => l.id == id);

        public List<Locacao> getAll(string username, string busca = null)
        {
           var user = _context.Users.FirstOrDefault(u => u.Email == username);


           return _context.Locacao.Include(l => l.Filme).Where(l => l.userId == user.Id).ToList();
         }

        public bool Update(Locacao l)
        {
            try
            {
                _context.Update(l);
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
