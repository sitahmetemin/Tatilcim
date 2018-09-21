﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tatilcim.Admin.Models;
using Tatilcim.Core;

namespace Tatilcim.Admin.Controllers
{
    public class BasvuruController : Controller
    {
        // GET: Basvuru
        public ActionResult Index()
        {
            ViewVeriModel model = new ViewVeriModel();
            using (TatilcimContext _context = new TatilcimContext())
            {
                model.Otel = _context.Otels.Where(x => x.Status == false && x.DeletedAt == null).OrderByDescending(x => x.CreatedAt).ToList();
            }
            return View(model);
        }


        [HttpGet]
        public JsonResult GetDetail(int Id)
        {
            
            using (TatilcimContext _con = new TatilcimContext())
            {
                var otel = _con.Otels.Find(Id);
                return Json(otel, JsonRequestBehavior.AllowGet);
            }
            
        }

        [HttpGet]
        public JsonResult Activated(int Id)
        {
            using (TatilcimContext _con = new TatilcimContext())
            {
                var otel = _con.Otels.Find(Id);
                otel.Status = true;
                if (_con.SaveChanges() > 0)
                {
                    return Json("success", JsonRequestBehavior.AllowGet);
                }
                return Json("error", JsonRequestBehavior.AllowGet);
            }
            
        }
    }

}