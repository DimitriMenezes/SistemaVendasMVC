using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace SistemaVendas.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Preço { get; set; }
        public int Estoque { get; set; }
        public DateTime DataFabricacao { get; set; }
        public bool Valido { get; set; }

        public virtual ICollection<ItemVenda> ItemsDeVenda { get; set; }
    }

}
