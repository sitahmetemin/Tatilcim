using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tatilcim.Admin.Models;
using Tatilcim.Core;

namespace Tatilcim.Admin.Controllers
{
    public class OtelController : Controller
    {
        
        // GET: Otel
        public ActionResult Index()
        {
            ViewVeriModel model = new ViewVeriModel();
            using (TatilcimContext _context = new TatilcimContext())
            {
                model.Otel = _context.Otels.ToList();
            }
            return View(model);
        }

        
    }
}