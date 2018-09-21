using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tatilcim.Admin.Models;
using Tatilcim.Core;
using Tatilcim.Domain.Concrate;

namespace Tatilcim.Admin.Controllers
{
    public class UyeController : Controller
    {
        // GET: Uye
        public ActionResult Index()
        {
            ViewVeriModel model = new ViewVeriModel();
            TatilcimContext _context = new TatilcimContext();
            
                model.User = _context.Users.Where(x => x.AuthorityId != 1).ToList();
                return View(model);
            
            
        }

        [HttpGet]
        public ActionResult Add()
        {
            ViewVeriModel model = new ViewVeriModel();
            using (TatilcimContext _context = new TatilcimContext())
            {
                model.Authorities = _context.Authorities.ToList();
                model.Otel = _context.Otels.Where(z => z.Status && z.DeletedAt == null).ToList();
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(FormCollection form)
        {
            var YetkiId = Convert.ToInt32(form["AuthorityId"]);
            var otelBilgi = Convert.ToInt32(form["OtelId"]);
            User kullanici = new User()
            {
                Name = form["Name"],
                Description = form["Description"],
                Email = form["Email"],
                AuthorityId = YetkiId,
                DisplayName = form["DisplayName"],
                Password = form["Password"],
                OtelId = otelBilgi,
                CreatedAt = DateTime.Now,
                Image = "Image",
                
            };

            using (TatilcimContext _con = new TatilcimContext())
            {
                _con.Users.Add(kullanici);
                _con.SaveChanges();
            }
            return RedirectToAction("Index", "Uye");
        }
    }
}