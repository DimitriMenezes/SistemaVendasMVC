using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SistemaVendas.Models;

namespace SistemaVendas.Context
{
    public class VendasContext : DbContext
    {
        public VendasContext() : base("VendasContext")
        {            

        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Estoque> Estoque { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
