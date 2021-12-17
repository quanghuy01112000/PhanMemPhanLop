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
    public class LoaiHinhDuLichesController : Controller
    {
        private TourDLEntities db = new TourDLEntities();
        private LoaiHinhDuLich lhdl = new LoaiHinhDuLich();
        // GET: LoaiHinhDuLiches
        public ActionResult Index(String q)
        {
            List<LoaiHinhDuLich> lsT;
            lhdl.getDSLoaiHinh();
            //var tourDuLiches = db.TourDuLiches.Include(t => t.LoaiHinhDuLich);
            if (!String.IsNullOrEmpty(q))
            {
                lsT = lhdl.timKiemLoaiHinh(q);
            }
            else
                lsT = LoaiHinhDuLich.listLoaiHinh ;
            return View(lsT);
        }

        // GET: LoaiHinhDuLiches/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiHinhDuLich loaiHinhDuLich = db.LoaiHinhDuLiches.Find(id);
            if (loaiHinhDuLich == null)
            {
                return HttpNotFound();
            }
            return View(loaiHinhDuLich);
        }

        // GET: LoaiHinhDuLiches/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoaiHinhDuLiches/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaLoaiHinh,TenLoaiHinh")] LoaiHinhDuLich loaiHinhDuLich)
        {
            if (ModelState.IsValid)
            {
                db.LoaiHinhDuLiches.Add(loaiHinhDuLich);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(loaiHinhDuLich);
        }

        // GET: LoaiHinhDuLiches/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiHinhDuLich loaiHinhDuLich = db.LoaiHinhDuLiches.Find(id);
            if (loaiHinhDuLich == null)
            {
                return HttpNotFound();
            }
            return View(loaiHinhDuLich);
        }

        // POST: LoaiHinhDuLiches/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaLoaiHinh,TenLoaiHinh")] LoaiHinhDuLich loaiHinhDuLich)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loaiHinhDuLich).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loaiHinhDuLich);
        }

        // GET: LoaiHinhDuLiches/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiHinhDuLich loaiHinhDuLich = db.LoaiHinhDuLiches.Find(id);
            if (loaiHinhDuLich == null)
            {
                return HttpNotFound();
            }
            return View(loaiHinhDuLich);
        }

        // POST: LoaiHinhDuLiches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LoaiHinhDuLich loaiHinhDuLich = db.LoaiHinhDuLiches.Find(id);
            db.LoaiHinhDuLiches.Remove(loaiHinhDuLich);
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
