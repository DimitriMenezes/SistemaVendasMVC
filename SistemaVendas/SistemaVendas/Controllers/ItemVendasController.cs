using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SistemaVendas.Context;
using SistemaVendas.Models;

namespace SistemaVendas.Controllers
{
    public class ItemVendasController : Controller
    {
        private VendasContext db = new VendasContext();

        // GET: ItemVendas
        public ActionResult Index()
        {
            var itemVendas = db.ItemVendas.Include(i => i.Produto);
            return View(itemVendas.ToList());
        }

        // GET: ItemVendas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemVenda itemVenda = db.ItemVendas.Find(id);
            if (itemVenda == null)
            {
                return HttpNotFound();
            }
            return View(itemVenda);
        }

        // GET: ItemVendas/Create
        public ActionResult Create()
        {
            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Descricao");
            return View();
        }

        // POST: ItemVendas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Quantidade,ProdutoId")] ItemVenda itemVenda)
        {
            if (ModelState.IsValid)
            {
                db.ItemVendas.Add(itemVenda);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Descricao", itemVenda.ProdutoId);
            return View(itemVenda);
        }

        // GET: ItemVendas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemVenda itemVenda = db.ItemVendas.Find(id);
            if (itemVenda == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Descricao", itemVenda.ProdutoId);
            return View(itemVenda);
        }

        // POST: ItemVendas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Quantidade,ProdutoId")] ItemVenda itemVenda)
        {
            if (ModelState.IsValid)
            {
                db.Entry(itemVenda).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Descricao", itemVenda.ProdutoId);
            return View(itemVenda);
        }

        // GET: ItemVendas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemVenda itemVenda = db.ItemVendas.Find(id);
            if (itemVenda == null)
            {
                return HttpNotFound();
            }
            return View(itemVenda);
        }

        // POST: ItemVendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ItemVenda itemVenda = db.ItemVendas.Find(id);
            db.ItemVendas.Remove(itemVenda);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
