using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tatilcim.Core;
using Tatilcim.Core.Services;

namespace Tatilcim.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            if (Session["Id"] != null)
            {
                Session.RemoveAll();
            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            var kAdi = form["DisplayName"];
            var kSifre = form["Password"];
            using (TatilcimContext _context = new TatilcimContext())
            {
                var kullanici = _context.Users.FirstOrDefault(x => x.DisplayName == kAdi && x.Password == kSifre && x.AuthorityId == 1);
                if (kullanici != null)
                {
                    Session.Add("Id", kullanici.Id);
                    Session.Add("Name", kullanici.Name);
                    
                    return RedirectToAction("Index", "Home");
                }
            }
            //return Redirect("/Login");
            return View();

        }
    }
}