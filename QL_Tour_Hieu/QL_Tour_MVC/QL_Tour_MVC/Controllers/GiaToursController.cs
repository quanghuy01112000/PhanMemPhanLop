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
    public class GiaToursController : Controller
    {
        private TourDLEntities db = new TourDLEntities();

        // GET: GiaTours
        public ActionResult Index()
        {
            var giaTours = db.GiaTours.Include(g => g.TourDuLich);
            return View(giaTours.ToList());
        }

        // GET: GiaTours/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GiaTour giaTour = db.GiaTours.Find(id);
            if (giaTour == null)
            {
                return HttpNotFound();
            }
            return View(giaTour);
        }

        // GET: GiaTours/Create
        public ActionResult Create()
        {
            ViewBag.MaTour = new SelectList(db.TourDuLiches, "MaTour", "TenTour");
            return View();
        }

        // POST: GiaTours/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaGia,ThanhTien,ThoiGianBatDau,ThoiGianKetThuc,MaTour")] GiaTour giaTour)
        {
            if (ModelState.IsValid)
            {
                db.GiaTours.Add(giaTour);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaTour = new SelectList(db.TourDuLiches, "MaTour", "TenTour", giaTour.MaTour);
            return View(giaTour);
        }

        // GET: GiaTours/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GiaTour giaTour = db.GiaTours.Find(id);
            if (giaTour == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaTour = new SelectList(db.TourDuLiches, "MaTour", "TenTour", giaTour.MaTour);
            return View(giaTour);
        }

        // POST: GiaTours/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaGia,ThanhTien,ThoiGianBatDau,ThoiGianKetThuc,MaTour")] GiaTour giaTour)
        {
            if (ModelState.IsValid)
            {
                db.Entry(giaTour).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaTour = new SelectList(db.TourDuLiches, "MaTour", "TenTour", giaTour.MaTour);
            return View(giaTour);
        }

        // GET: GiaTours/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GiaTour giaTour = db.GiaTours.Find(id);
            if (giaTour == null)
            {
                return HttpNotFound();
            }
            return View(giaTour);
        }

        // POST: GiaTours/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GiaTour giaTour = db.GiaTours.Find(id);
            db.GiaTours.Remove(giaTour);
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
