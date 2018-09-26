using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tatilcim.Common.Dtos;
using Tatilcim.Core.Services;

namespace Tatilcim.UI.Controllers
{
    public class DetailController : Controller
    {
        // GET: Detail
        public ActionResult Otel(int Id)
        {
            OtelDto o = new OtelDto();
            o.Id = Id;

            var DbOtel = Services.OtelService.GetOtelByName(o);
            return View(DbOtel);
        }

        public ActionResult Oda()
        {
            return View();

        }

        public ActionResult _PartialOdaDetay()
        {

            var ottel = Convert.ToInt32(TempData["OtelIdsi"]);
            OtelDto otel = new OtelDto();
            otel.Id = ottel;
            var DBOda = Services.OtelService.GetRooms(otel);
            return PartialView(DBOda);
        }
    }
}