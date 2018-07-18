using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVendas.Models;

namespace SistemaVendas.Context
{
    public class EstoqueInicial
    {
        void CriarEstoqueInicial() {
            var produtos = new List<Produto>
            {
                new Produto("Leite em pó", DateTime.UtcNow, 4.59),
                new Produto("Manteiga de Fazenda", DateTime.UtcNow, 15.99),
                new Produto("Leite em pó", DateTime.UtcNow, 4.59),
                new Produto("Detergente", DateTime.UtcNow, 1.19),
            };

        }
    }
}
