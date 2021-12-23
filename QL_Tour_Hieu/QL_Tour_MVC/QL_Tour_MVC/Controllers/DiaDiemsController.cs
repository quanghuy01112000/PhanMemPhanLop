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
    public class DiaDiemsController : Controller
    {
        private TourDLEntities db = new TourDLEntities();
        private DiaDiem dd = new DiaDiem();
        // GET: DiaDiems
        public ActionResult Index(String q)
        {
            List<DiaDiem> lsT;
            dd.getDSDiaDiem();
            //var tourDuLiches = db.TourDuLiches.Include(t => t.LoaiHinhDuLich);
            if (!String.IsNullOrEmpty(q))
            {
                lsT = dd.timKiemDiaDiem(q);
            }
            else
                lsT = DiaDiem.listDiaDiem;
            return View(lsT);
        }

        // GET: DiaDiems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiaDiem diaDiem = dd.timKiemDiaDiemById((int)id);
            if (diaDiem == null)
            {
                return HttpNotFound();
            }
            return View(diaDiem);
        }

        // GET: DiaDiems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DiaDiems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaDiaDiem,TenDiaDiem")] DiaDiem diaDiem)
        {
            if (ModelState.IsValid)
            {
                dd.themDiaDiem(diaDiem);
                return RedirectToAction("Index");
            }

            return View(diaDiem);
        }

        // GET: DiaDiems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiaDiem diaDiem = dd.timKiemDiaDiemById((int)id);
            if (diaDiem == null)
            {
                return HttpNotFound();
            }
            return View(diaDiem);
        }

        // POST: DiaDiems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaDiaDiem,TenDiaDiem")] DiaDiem diaDiem)
        {
            if (ModelState.IsValid)
            {
                dd.suaDiaDiem(diaDiem);
                return RedirectToAction("Index");
            }
            return View(diaDiem);
        }

        // GET: DiaDiems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiaDiem diaDiem = dd.timKiemDiaDiemById((int)id);
            if (diaDiem == null)
            {
                return HttpNotFound();
            }
            return View(diaDiem);
        }

        // POST: DiaDiems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DiaDiem diaDiem = dd.timKiemDiaDiemById((int)id);
            if(dd.xoaDiaDiem(diaDiem))
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
