using SistemaVendas.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SistemaVendas.Context
{
    public class VendasContext : DbContext
    { 

        public VendasContext() : base("VendasContext")
        {

        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<ItemVenda> ItemVendas { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Evitar tabelas descritas no plural
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new VendaTypeConfiguration());
            modelBuilder.Configurations.Add(new ItemVendaTypeConfiguration());
        }
    }
}