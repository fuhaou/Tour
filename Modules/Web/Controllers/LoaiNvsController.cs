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
    public class LoaiNvsController : Controller
    {
        // GET: LoaiNvs
        public ActionResult Index()
        {
            return View(Models.LoaiNvModel.Instance.GetAll());
        }

        // GET: LoaiNvs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoaiNvs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LoaiNvId,LoaiNvName")] LoaiNv loaiNv)
        {
            if (ModelState.IsValid) {
                Models.LoaiNvModel.Instance.Insert(loaiNv.LoaiNvName);
                return RedirectToAction("Index");
            }
            return View(loaiNv);
        }

        // GET: LoaiNvs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiNv loaiNv = Models.LoaiNvModel.Instance.GetById(id.GetValueOrDefault(0));
            if (loaiNv == null)
            {
                return HttpNotFound();
            }
            return View(loaiNv);
        }

        // POST: LoaiNvs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LoaiNvId,LoaiNvName")] LoaiNv loaiNv)
        {
            if (ModelState.IsValid) {
                Models.LoaiNvModel.Instance.Update(loaiNv.LoaiNvId, loaiNv.LoaiNvName);
                return RedirectToAction("Index");
            }
            return View(loaiNv);
        }
        
       
    }
}
