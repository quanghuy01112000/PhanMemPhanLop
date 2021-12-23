using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QL_TourDuLich.BUS;

namespace QL_Tour_MVC.Controllers
{
    public class ChiPhisController : Controller
    {
        private TourDLEntities db = new TourDLEntities();
        private ChiPhi cp = new ChiPhi();
        // GET: ChiPhis
        public ActionResult Index()
        {
            var chiPhis = db.ChiPhis.Include(c => c.DoanDuLich).Include(c => c.LoaiChiPhi);
            return View(chiPhis.ToList());
        }

        // GET: ChiPhis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiPhi chiPhi = db.ChiPhis.Find(id);
            if (chiPhi == null)
            {
                return HttpNotFound();
            }
            return View(chiPhi);
        }

        // GET: ChiPhis/Create
        public ActionResult Create()
        {
            ViewBag.MaDoan = new SelectList(db.DoanDuLiches, "MaDoan", "MaDoan");
            ViewBag.MaLoaiChiPhi = new SelectList(db.LoaiChiPhis, "MaLoaiChiPhi", "TenLoaiChiPhi");
            return View();
        }

        // POST: ChiPhis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaChiPhi,MaDoan,SoTien,MaLoaiChiPhi")] ChiPhi chiPhi)
        {
            if (ModelState.IsValid)
            {
                db.ChiPhis.Add(chiPhi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaDoan = new SelectList(db.DoanDuLiches, "MaDoan", "MaDoan", chiPhi.MaDoan);
            ViewBag.MaLoaiChiPhi = new SelectList(db.LoaiChiPhis, "MaLoaiChiPhi", "TenLoaiChiPhi", chiPhi.MaLoaiChiPhi);
            return View(chiPhi);
        }

        // GET: ChiPhis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiPhi chiPhi = db.ChiPhis.Find(id);
            if (chiPhi == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaDoan = new SelectList(db.DoanDuLiches, "MaDoan", "MaDoan", chiPhi.MaDoan);
            ViewBag.MaLoaiChiPhi = new SelectList(db.LoaiChiPhis, "MaLoaiChiPhi", "TenLoaiChiPhi", chiPhi.MaLoaiChiPhi);
            return View(chiPhi);
        }

        // POST: ChiPhis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaChiPhi,MaDoan,SoTien,MaLoaiChiPhi")] ChiPhi chiPhi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chiPhi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaDoan = new SelectList(db.DoanDuLiches, "MaDoan", "MaDoan", chiPhi.MaDoan);
            ViewBag.MaLoaiChiPhi = new SelectList(db.LoaiChiPhis, "MaLoaiChiPhi", "TenLoaiChiPhi", chiPhi.MaLoaiChiPhi);
            return View(chiPhi);
        }

        // GET: ChiPhis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiPhi chiPhi = db.ChiPhis.Find(id);
            if (chiPhi == null)
            {
                return HttpNotFound();
            }
            return View(chiPhi);
        }

        // POST: ChiPhis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ChiPhi chiPhi = db.ChiPhis.Find(id);
            db.ChiPhis.Remove(chiPhi);
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
