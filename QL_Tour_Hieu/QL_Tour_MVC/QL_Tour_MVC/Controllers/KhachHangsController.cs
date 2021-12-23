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
    public class KhachHangsController : Controller
    {
        private TourDLEntities db = new TourDLEntities();
        private KhachHang kh = new KhachHang();
        // GET: KhachHangs
        public ActionResult Index(String q)
        {
            //return View(db.KhachHangs.ToList());
            List<KhachHang> lsKH;
            kh.getDSKhachHang();
            //var tourDuLiches = db.TourDuLiches.Include(t => t.LoaiHinhDuLich);
            if (!String.IsNullOrEmpty(q))
            {
                lsKH = kh.timKiemKhachHang(q);
            }
            else
                lsKH = KhachHang.listKhachHang;
            return View(lsKH);
        }

        // GET: KhachHangs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhachHang khachHang = kh.timKiemKhachHangById((int)id);
            if (khachHang == null)
            {
                return HttpNotFound();
            }
            return View(khachHang);
        }

        // GET: KhachHangs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KhachHangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaKhachHang,HoTen,soCMND,DiaChi,GioiTinh,SDT,QuocTich")] KhachHang khachHang)
        {
            if (ModelState.IsValid)
            {
                kh.themKhachHang(khachHang);
                return RedirectToAction("Index");
            }

            return View(khachHang);
        }

        // GET: KhachHangs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhachHang khachHang = kh.timKiemKhachHangById((int)id);
            if (khachHang == null)
            {
                return HttpNotFound();
            }
            return View(khachHang);
        }

        // POST: KhachHangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaKhachHang,HoTen,soCMND,DiaChi,GioiTinh,SDT,QuocTich")] KhachHang khachHang)
        {
            if (ModelState.IsValid)
            {
                kh.suaKhachHang(khachHang);
                return RedirectToAction("Index");
            }
            return View(khachHang);
        }

        // GET: KhachHangs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhachHang khachHang = kh.timKiemKhachHangById((int)id);
            if (khachHang == null)
            {
                return HttpNotFound();
            }
            return View(khachHang);
        }

        // POST: KhachHangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            KhachHang khachHang = kh.timKiemKhachHangById((int)id);
            if (kh.xoaKhachHang(khachHang))
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Delete");
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
