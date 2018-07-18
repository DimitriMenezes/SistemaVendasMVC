using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVendas.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataFabricacao { get; set; }
        public float Preço { get; set; }
        public virtual ICollection<Produto> Produto { get; set; }
    }
}
