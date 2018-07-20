using SistemaVendas.Models;
using System;
using System.Collections.Generic;

namespace SistemaVendas.ViewModels
{
    public class CarrinhoVendaViewModel
    {
       public Produto Produto { get; set; }
       public int Quantidade { get; set; }
    }
}