using CrudEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cidade> Cidades { get; set; }

    }
}
