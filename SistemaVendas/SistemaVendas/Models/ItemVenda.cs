using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SistemaVendas.Models
{
    public class ItemVenda
    {
        [Key]
        public int Id { get; set; }       
        public int Quantidade { get; set; }       
        public int ProdutoId { get; set; }

        [ForeignKey("ProdutoId")]
        public Produto Produto { get; set; }

        public virtual ICollection<Venda> Vendas { get; set; }
    }

    internal class ItemVendaTypeConfiguration : EntityTypeConfiguration<ItemVenda>
    {
        public ItemVendaTypeConfiguration()
        {
            HasRequired(s => s.Produto)
                .WithMany(a => a.ItemsDeVenda)
                .Map(a => { a.MapKey("ProdutoId"); });
        }
    }
}