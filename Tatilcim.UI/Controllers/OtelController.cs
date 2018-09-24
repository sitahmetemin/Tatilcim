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

        public ActionResult _PartialOdalar()
        {
            var otelID = Convert.ToInt32(Session["OtelId"]);
            OtelDto otl = new OtelDto();
            otl.Id = otelID;
            var odalar = Services.OtelService.GetRooms(otl);
            
            return PartialView(odalar);
        }

        public ActionResult OdaEkle(OdaDto oda)
        {

            var otelID = Convert.ToInt32(Session["OtelId"]);
            oda.OtelId = otelID;
            Services.OtelService.InsertNewRoom(oda);

            return Redirect("/Otel/Index");
        }

        public ActionResult Sil(int Id)
        {
            OdaDto oda = new OdaDto();
            oda.Id = Id;
            Services.OtelService.DeleteRoom(oda);

            return Redirect("/Otel/Index");
        }

        public ActionResult RezerveYap()
        {
            return null;
        }
        
    }
}