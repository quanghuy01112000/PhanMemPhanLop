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
    public class TourDuLichesController : Controller
    {
        private TourDLEntities db = new TourDLEntities();
        TourDuLich tour = new TourDuLich();

        // GET: TourDuLiches
        public ActionResult Index(String q)
        {
            List<TourDuLich> lsT;
            tour.getDanhsachTour();
            //var tourDuLiches = db.TourDuLiches.Include(t => t.LoaiHinhDuLich);
            if (!String.IsNullOrEmpty(q))
            {
                lsT = tour.timKiem(q);
            }else
            lsT = TourDuLich.lstTours;
            return View(lsT);
        }
        // GET: TourDuLiches/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TourDuLich tourDuLich = db.TourDuLiches.Find(id);
            if (tourDuLich == null)
            {
                return HttpNotFound();
            }
            return View(tourDuLich);
        }

        // GET: TourDuLiches/Create
        public ActionResult Create()
        {
            ViewBag.MaLoaiHinh = new SelectList(db.LoaiHinhDuLiches, "MaLoaiHinh", "TenLoaiHinh");
            return View();
        }

        // POST: TourDuLiches/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaTour,TenTour,DacDiem,TrangThai,MaLoaiHinh,NgayBatDau,NgayKetThuc,HienThi")] TourDuLich tourDuLich)
        {
            if (ModelState.IsValid)
            {
                db.TourDuLiches.Add(tourDuLich);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaLoaiHinh = new SelectList(db.LoaiHinhDuLiches, "MaLoaiHinh", "TenLoaiHinh", tourDuLich.MaLoaiHinh);
            return View(tourDuLich);
        }

        // GET: TourDuLiches/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TourDuLich tourDuLich = db.TourDuLiches.Find(id);
            if (tourDuLich == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaLoaiHinh = new SelectList(db.LoaiHinhDuLiches, "MaLoaiHinh", "TenLoaiHinh", tourDuLich.MaLoaiHinh);
            return View(tourDuLich);
        }

        // POST: TourDuLiches/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaTour,TenTour,DacDiem,TrangThai,MaLoaiHinh,NgayBatDau,NgayKetThuc,HienThi")] TourDuLich tourDuLich)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tourDuLich).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaLoaiHinh = new SelectList(db.LoaiHinhDuLiches, "MaLoaiHinh", "TenLoaiHinh", tourDuLich.MaLoaiHinh);
            return View(tourDuLich);
        }

        // GET: TourDuLiches/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TourDuLich tourDuLich = db.TourDuLiches.Find(id);
            if (tourDuLich == null)
            {
                return HttpNotFound();
            }
            return View(tourDuLich);
        }

        // POST: TourDuLiches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TourDuLich tourDuLich = db.TourDuLiches.Find(id);
            db.TourDuLiches.Remove(tourDuLich);
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
