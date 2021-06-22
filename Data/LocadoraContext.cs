using LocadoraDeFilmesPF.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraDeFilmesPF.Data
{
    public class LocadoraContext : IdentityDbContext // classe de contexto do nosso banco de dados (locadora)
    {
        public LocadoraContext(DbContextOptions<LocadoraContext> options) : base(options)
        {}

        public DbSet<Filme> Filme { get; set; } // seta as configurações da tabela filme
        public DbSet<Locacao> Locacao { get; set; } // seta as configurações da tabela locacao

        public DbSet<Funcionario> Funcionario { get; set; }

    }
}
