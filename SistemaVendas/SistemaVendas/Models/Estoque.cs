using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SistemaVendas.Models
{
    public class Estoque
    {
        [Key]
        public int Id { get; set; }

        public int Quantidade { get; set; }

        public int ProdutoId { get; set; }

        [ForeignKey("ProdutoId")]
        public Produto Produto { get; set; }
    }

    internal class EstoqueTypeConfiguration : EntityTypeConfiguration<Estoque>
    {
        public EstoqueTypeConfiguration()
        {
            HasRequired(s => s.Produto)
                .WithMany(a => a.Estoques)
                .Map(a => { a.MapKey("ProdutoId"); });
        }
    }
}