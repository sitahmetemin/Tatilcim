using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tatilcim.Admin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session["Id"] == null)
            {
                return Redirect("/Login/Index");
            }
            return View();
        }

        
    }
}