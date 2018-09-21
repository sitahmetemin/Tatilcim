using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tatilcim.Common.Dtos;
using Tatilcim.Core.Services;

namespace Tatilcim.UI.Controllers
{
    public class OtelController : Controller
    {
        // GET: Otel
        public ActionResult Index()
        {
            var otelID = Convert.ToInt32(Session["OtelId"]);
            OtelDto otl = new OtelDto();
            otl.Id = otelID;
            var oteller = Services.OtelService.GetOtelByName(otl);

            return View(oteller);
        }
    }
}