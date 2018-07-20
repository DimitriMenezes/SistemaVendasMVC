using SistemaVendas.Context;
using SistemaVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaVendas.Controllers
{
    public class CarrinhoVendasController : Controller
    {

        private VendasContext db = new VendasContext();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddVendaItem([Bind(Include = "Id,Quantidade,ProdutoId")] ItemVenda itemVenda)
        {
            if (ModelState.IsValid)
            {
                db.ItemVendas.Add(itemVenda);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(itemVenda);
        }
    }
}