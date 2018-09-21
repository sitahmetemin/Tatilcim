using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
    }
}