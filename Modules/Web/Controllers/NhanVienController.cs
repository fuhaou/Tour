using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Models.Dao;

namespace Web.Controllers
{
    public class NhanVienController : Controller
    {
        // GET: NhanVien
        public ActionResult Index(string searchdata)
        {
            return View(
                Models.NhanVienModel.Instance.SearchData(searchdata)
            );
        }
        
        // GET: NhanVien/Create
        public ActionResult Create()
        {
            ViewBag.FkLoaiNv = new SelectList( Models.LoaiNvModel.Instance.GetAll(), "LoaiNvId", "LoaiNvName");
            return View();
        }

        // POST: NhanVien/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NhanVienId,NhanVienTen,NhanVienDiaChi,NhanVienSdt,NhanVienCMND,FkLoaiNv")] NhanVien nhanVien)
        {
            if (ModelState.IsValid) {
                Models.NhanVienModel.Instance.Insert(
                    nhanVien.NhanVienTen,
                    nhanVien.NhanVienDiaChi,
                    nhanVien.NhanVienSdt,
                    nhanVien.NhanVienCMND,
                    nhanVien.FkLoaiNv
                );
                return RedirectToAction("Index");
            }
            ViewBag.FkLoaiNv = new SelectList(Models.LoaiNvModel.Instance.GetAll(), "LoaiNvId", "LoaiNvName");
            return View(nhanVien);
        }

        // GET: NhanVien/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhanVien nhanVien = Models.NhanVienModel.Instance.GetById(id.GetValueOrDefault(0));
            if (nhanVien == null)
            {
                return HttpNotFound();
            }
            ViewBag.FkLoaiNv = new SelectList(Models.LoaiNvModel.Instance.GetAll(), "LoaiNvId", "LoaiNvName", nhanVien.FkLoaiNv);
            return View(nhanVien);
        }

        // POST: NhanVien/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NhanVienId,NhanVienCode,NhanVienTen,NhanVienDiaChi,NhanVienSdt,NhanVienCMND,FkLoaiNv")] NhanVien nhanVien)
        {
            if (ModelState.IsValid) {
                Models.NhanVienModel.Instance.UpdateById(
                    nhanVien.NhanVienId,
                    nhanVien.NhanVienTen,
                    nhanVien.NhanVienDiaChi,
                    nhanVien.NhanVienSdt,
                    nhanVien.NhanVienCMND,
                    nhanVien.FkLoaiNv
                );
                return RedirectToAction("Index");
            }
            ViewBag.FkLoaiNv = new SelectList(Models.LoaiNvModel.Instance.GetAll(), "LoaiNvId", "LoaiNvName", nhanVien.FkLoaiNv);
            return View(nhanVien);
        }
    }
}
