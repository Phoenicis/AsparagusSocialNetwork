using System;
using System.Dynamic;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SocialNetwork.DAL;
using SocialNetwork.Models;

namespace SocialNetwork.Controllers
{
    public class AsparagusController : Controller
    {
        private SocialNetworkContext db = new SocialNetworkContext();

        // GET: Asparagus
        public ActionResult Index()
        {
            return View(db.Asparaguses.Include(x => x.User).Where(x => x.User != null).ToList());
            //.Include(x => x.User).Where(x => x.User != null)
           
        }

        // GET: Asparagus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Asparagus asparagus = db.Asparaguses.Find(id);
            if (asparagus == null)
            {
                return HttpNotFound();
            }
            return View(asparagus);
        }

        // GET: Asparagus/Create
        public ActionResult Create()
        {

            return View();
        }
        

        // POST: Asparagus/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Date")] Asparagus asparagus)
        {
            if (ModelState.IsValid)
            {
                db.Asparaguses.Add(asparagus);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(asparagus);
        }

        // GET: Asparagus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Asparagus asparagus = db.Asparaguses.Find(id);
            if (asparagus == null)
            {
                return HttpNotFound();
            }
            return View(asparagus);
        }

        // POST: Asparagus/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Date")] Asparagus asparagus)
        {
            if (ModelState.IsValid)
            {
                db.Entry(asparagus).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(asparagus);
        }

        // GET: Asparagus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Asparagus asparagus = db.Asparaguses.Find(id);
            if (asparagus == null)
            {
                return HttpNotFound();
            }
            return View(asparagus);
        }

        // POST: Asparagus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Asparagus asparagus = db.Asparaguses.Find(id);
            db.Asparaguses.Remove(asparagus);
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
