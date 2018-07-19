using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaVendas.Models
{
    public class Produto
    {
        [Key]
        public int ID { get; set; }
        public string Descricao { get; set; }
        public DateTime DataFabricacao { get; set; }
        public double Preço { get; set; }
        public bool Disponivel { get; set; }

        public virtual ICollection<Venda> Vendas { get; set; }
        public virtual ICollection<Estoque> Estoques { get; set; }
    }
}
