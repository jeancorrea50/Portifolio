using Microsoft.EntityFrameworkCore;
using Portifolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portifolio.Data
{
    public class IAgendamentoDbContext : DbContext
    {
        public DbSet<Motorista> Motoristas { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<NotaFiscal> NotaFiscal { get; set; }
        public DbSet<Agenda> Agenda { get; set; }

        // String de conexão com o Banco de dados (SQL)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=Bf18102907;Persist Security Info=True;User ID=jeancpcorrea;Initial Catalog=AgendaSBrasil;Data Source=DESKTOP-43O4B71\\SQLEXPRESS");
        }

        
    }

}