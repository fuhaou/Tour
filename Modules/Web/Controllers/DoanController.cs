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
    public class DoanController : Controller
    {
        // GET: Doan
        public ActionResult Index()
        {
            return View(
                Models.DoanModel.Instance.GetAll()
            );
        }
        
        public ActionResult Create()
        {
            return View();
        }

        // POST: Doan/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( string tourcode, [Bind(Include = "DoanTen,DoanNgayDi,DoanNgayVe,DoanHotelCost,DoanFoodCost,DoanVehicleCost,DoanAdditionalCost,DoanTourPrice,DoanNgayTao,DoanTrangThai")] Doan doan)
        {
            if (ModelState.IsValid) {
                Models.DoanModel.Instance.Insert(
                    doan.DoanTen,
                    doan.DoanNgayDi,
                    doan.DoanNgayVe,
                    (float?)doan.DoanHotelCost,
                    (float?)doan.DoanVehicleCost,
                    (float?)doan.DoanFoodCost,
                    (float?)doan.DoanAdditionalCost,
                    tourcode
                );
                return RedirectToAction("Index");
            }
            return View(doan);
        }

        // GET: Doan/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doan doan = Models.DoanModel.Instance.GetById(id.GetValueOrDefault(0));
            ViewBag.CTDK = Models.CTDoanKhachModel.Instance.GetByDoanId(id.GetValueOrDefault(0));
            ViewBag.CTDNV = Models.DoanModel.Instance.GetCtDoanNvsByDoanId(id.GetValueOrDefault(0));
            if (doan == null)
            {
                return HttpNotFound();
            }
            return View(doan);
        }

        // POST: Doan/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string tourcode, [Bind(Include = "DoanId,DoanTen,DoanNgayDi,DoanNgayVe,DoanHotelCost,DoanFoodCost,DoanVehicleCost,DoanAdditionalCost")] Doan doan)
        {
            if (ModelState.IsValid ) {
                Models.DoanModel.Instance.Update(
                    doan.DoanId,
                    doan.DoanTen,
                    doan.DoanNgayDi,
                    doan.DoanNgayVe,
                    (float?) doan.DoanHotelCost,
                    (float?) doan.DoanVehicleCost,
                    (float?) doan.DoanFoodCost,
                    (float?) doan.DoanAdditionalCost,
                    tourcode
                );
                return RedirectToAction("Index");
            }
            return View(doan);
        }
        // GET: Doan/ThemKhach/5
        public ActionResult ThemKhach(string khachhangcode, int DoanId)
        {
            Models.DoanModel.Instance.ThemKhach(DoanId, khachhangcode);
            return RedirectToAction("Edit", new  { id = DoanId});
        }


        // GET: Doan/PhanCong/5
        public ActionResult PhanCong(string nvcode, int DoanId) {
            Models.DoanModel.Instance.PhanCongNv(DoanId, nvcode);
            return RedirectToAction("Edit", new { id = DoanId });
        }
    }
}
