using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaVendas.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Vendas() {
            ViewBag.Message = "Vendas";

            return View();
        }

        public ActionResult Estoque() {
            ViewBag.Message = "Estoque dos Produtos";

            return View();
        }

        public ActionResult Produtos()
        {
            ViewBag.Message = "Disponibilidade dos Produtos";

            return View();
        }
    }
}