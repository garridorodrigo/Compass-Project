using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCompass.Models 
{
    public class Context : DbContext
    {
        public DbSet<Funcionario> Funcionarios { get; set; }
        public Context(DbContextOptions<Context> opcoes) : base(opcoes) 
        {
        
        }
    }
}
