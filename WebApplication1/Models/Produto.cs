using System;


namespace SistemaVendas.Models
{
    public class Produto
    {

        public int ID { get; set; }
        public string Descricao { get; set; }
        public DateTime DataFabricacao { get; set; }
        public double Preço { get; set; }

        public Produto(string Descricao,DateTime DataFabricacao, double Preço) {
            this.Descricao = Descricao;
            this.DataFabricacao = DataFabricacao;
            this.Preço = Preço;
        }

    }
}
