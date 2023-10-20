using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioConteiner.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioConteiner.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {            
        }

        public DbSet<Conteiner> Conteiners {get; set;}

        public DbSet<Movimentacao> Movimentacaos {get; set;}
    }
}