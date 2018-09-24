using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tatilcim.UI.Controllers
{
    public class DetailController : Controller
    {
        // GET: Detail
        public ActionResult Otel()
        {
            return View();
        }

        public ActionResult Oda()
        {
            return View();

        }
    }
}