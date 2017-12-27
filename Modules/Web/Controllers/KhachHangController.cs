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
    public class KhachHangController : Controller
    {
        // GET: KhachHang
        public ActionResult Index(string searchdata)
        {
            searchdata = searchdata ?? "";
            return View(
                Models.KhachHangModel.Instance.SearchSearchQuery(searchdata)
            );
        }

        // GET: KhachHang/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KhachHang/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "KhachHangId,KhachHangTen,KhachHangSdt,KhachHangDiaChi,CMND")] KhachHang khachHang)
        {
            if (ModelState.IsValid) {
                Models.KhachHangModel.Instance.InsertObject(khachHang);
                return RedirectToAction("Index");
            }
            return View(khachHang);
        }

        // GET: KhachHang/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhachHang khachHang = Models.KhachHangModel.Instance.GetById(id.GetValueOrDefault(0));
            if (khachHang == null)
            {
                return HttpNotFound();
            }
            return View(khachHang);
        }

        // POST: KhachHang/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "KhachHangId,KhachHangTen,KhachHangSdt,KhachHangDiaChi,CMND")] KhachHang khachHang)
        {
            if (ModelState.IsValid) {
                Models.KhachHangModel.Instance.UpdateById(
                    khachHang.KhachHangId,
                    khachHang.KhachHangTen,
                    khachHang.KhachHangSdt,
                    khachHang.KhachHangDiaChi,
                    khachHang.CMND
                );
                return RedirectToAction("Index");
            }
            return View(khachHang);
        }
    }
}
