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
    public class DoanDuLichesController : Controller
    {
        private TourDLEntities db = new TourDLEntities();

        // GET: DoanDuLiches
        public ActionResult Index()
        {
            var doanDuLiches = db.DoanDuLiches.Include(d => d.TourDuLich).Include(d => d.NoiDungTour);
            return View(doanDuLiches.ToList());
        }

        // GET: DoanDuLiches/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoanDuLich doanDuLich = db.DoanDuLiches.Find(id);
            if (doanDuLich == null)
            {
                return HttpNotFound();
            }
            return View(doanDuLich);
        }

        // GET: DoanDuLiches/Create
        public ActionResult Create()
        {
            ViewBag.MaTour = new SelectList(db.TourDuLiches, "MaTour", "TenTour");
            ViewBag.MaDoan = new SelectList(db.NoiDungTours, "MaDoan", "HanhTrinh");
            return View();
        }

        // POST: DoanDuLiches/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaDoan,NgayKhoiHanh,NgayKetThuc,DoanhThu,MaTour")] DoanDuLich doanDuLich)
        {
            if (ModelState.IsValid)
            {
                db.DoanDuLiches.Add(doanDuLich);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaTour = new SelectList(db.TourDuLiches, "MaTour", "TenTour", doanDuLich.MaTour);
            ViewBag.MaDoan = new SelectList(db.NoiDungTours, "MaDoan", "HanhTrinh", doanDuLich.MaDoan);
            return View(doanDuLich);
        }

        // GET: DoanDuLiches/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoanDuLich doanDuLich = db.DoanDuLiches.Find(id);
            if (doanDuLich == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaTour = new SelectList(db.TourDuLiches, "MaTour", "TenTour", doanDuLich.MaTour);
            ViewBag.MaDoan = new SelectList(db.NoiDungTours, "MaDoan", "HanhTrinh", doanDuLich.MaDoan);
            return View(doanDuLich);
        }

        // POST: DoanDuLiches/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaDoan,NgayKhoiHanh,NgayKetThuc,DoanhThu,MaTour")] DoanDuLich doanDuLich)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doanDuLich).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaTour = new SelectList(db.TourDuLiches, "MaTour", "TenTour", doanDuLich.MaTour);
            ViewBag.MaDoan = new SelectList(db.NoiDungTours, "MaDoan", "HanhTrinh", doanDuLich.MaDoan);
            return View(doanDuLich);
        }

        // GET: DoanDuLiches/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoanDuLich doanDuLich = db.DoanDuLiches.Find(id);
            if (doanDuLich == null)
            {
                return HttpNotFound();
            }
            return View(doanDuLich);
        }

        // POST: DoanDuLiches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DoanDuLich doanDuLich = db.DoanDuLiches.Find(id);
            db.DoanDuLiches.Remove(doanDuLich);
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
