using System;


namespace SistemaVendas.Models
{
    public class Produto
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public DateTime DataFabricacao { get; set; }
        public float Preço { get; set; }

    }
}
