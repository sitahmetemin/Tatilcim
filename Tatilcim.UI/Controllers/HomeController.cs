using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tatilcim.Core.Services;

namespace Tatilcim.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            if (TempData["Status"] != null)
            {
                ViewBag.Status = "succes";
                return View();
            }

            return View();

        }

        public ActionResult Oteller()
        {
            var oteller = Services.OtelService.GetActiveRandomOtels();
            return View(oteller);
        }

        public ActionResult _PartialViewAnasafaRandom()
        {
            var oteller = Services.OtelService.GetActiveRandomOtels();
            return PartialView(oteller);
        }
        
        public ActionResult Hakkinda()
        {
            return View();
        }


        public ActionResult Iletisim()
        {
            return View();
        }
    }
}