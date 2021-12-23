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
    public class LoaiChiPhisController : Controller
    {
        private TourDLEntities db = new TourDLEntities();
        private LoaiChiPhi lcp = new LoaiChiPhi();
        // GET: LoaiChiPhis
        public ActionResult Index(String q)
        {
            List<LoaiChiPhi> lsT;
            lcp.getDSLoaiChiPhi();
            //var tourDuLiches = db.TourDuLiches.Include(t => t.LoaiHinhDuLich);
            if (!String.IsNullOrEmpty(q))
            {
                lsT = lcp.timKiemLoaiChiPhi(q);
            }
            else
                lsT = LoaiChiPhi.listLoaiChiPhi;
            return View(lsT);
        }

        // GET: LoaiChiPhis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiChiPhi loaiChiPhi = lcp.timKiemLoaiChiPhiById((int)id);
            if (loaiChiPhi == null)
            {
                return HttpNotFound();
            }
            return View(loaiChiPhi);
        }

        // GET: LoaiChiPhis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoaiChiPhis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaLoaiChiPhi,TenLoaiChiPhi")] LoaiChiPhi loaiChiPhi)
        {
            if (ModelState.IsValid)
            {
                lcp.themLoaiChiPhi(loaiChiPhi);
                return RedirectToAction("Index");
            }

            return View(loaiChiPhi);
        }

        // GET: LoaiChiPhis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiChiPhi loaiChiPhi = lcp.timKiemLoaiChiPhiById((int)id);
            if (loaiChiPhi == null)
            {
                return HttpNotFound();
            }
            return View(loaiChiPhi);
        }

        // POST: LoaiChiPhis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaLoaiChiPhi,TenLoaiChiPhi")] LoaiChiPhi loaiChiPhi)
        {
            if (ModelState.IsValid)
            {
                lcp.suaLoaiChiPhi(loaiChiPhi);
                return RedirectToAction("Index");
            }
            return View(loaiChiPhi);
        }

        // GET: LoaiChiPhis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiChiPhi loaiChiPhi = lcp.timKiemLoaiChiPhiById((int)id);
            if (loaiChiPhi == null)
            {
                return HttpNotFound();
            }
            return View(loaiChiPhi);
        }

        // POST: LoaiChiPhis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LoaiChiPhi loaiChiPhi = lcp.timKiemLoaiChiPhiById((int)id);
            if(lcp.xoaLoaiChiPhi(loaiChiPhi))
                return RedirectToAction("Index");
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
