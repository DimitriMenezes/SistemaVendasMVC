using System;

namespace SistemaVendas.Models
{
    public class Estoque
    {
        public int Id { get; set; }
        public int ProdutoID { get; set; }
        public int Quantidade { get; set; }
        public Produto Produto { get; set; }
    }
}