using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVendas.Models
{
    public class Venda
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataVenda { get; set; }
        public float ValorTotal { get; set; }
        public int ProdutoId { get; set; }

        [ForeignKey("ProdutoId")]
        public Produto Produto{ get; set; }
    }

    internal class VendaTypeConfiguration : EntityTypeConfiguration<Venda>
    {
        public VendaTypeConfiguration()
        {
            HasRequired(s => s.Produto)
                .WithMany(a => a.Vendas)
                .Map(a => { a.MapKey("ProdutoId"); });
        }
    }

}
