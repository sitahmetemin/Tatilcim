using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using Tatilcim.Common.Dtos;
using Tatilcim.Core.Services;

namespace Tatilcim.UI.Controllers
{
    public class KayitController : Controller
    {
        // GET: Kayit
        public  ActionResult OtelBasvuru(string Name, string Address, string Cover, string Email, string Description, int Star, string Tel, string Gym, string Breakfast, string Bar, string CarPark, string Pool, string Restaurant, string RoomService, string Spa, string Wifi)
        {
            OtelDto dto = new OtelDto()
            {
                Name = Name,
                Address = Address,
                Cover = "Image",
                Email = Email,
                Description = Description,
                Star = Star,
                Tel = Tel,
                Status = false,
                Gym = Gym,
                Breakfast = Breakfast,
                Bar = Bar,
                CarPark = CarPark,
                Pool = Pool,
                Restaurant = Restaurant,
                RoomService = RoomService,
                Spa = Spa,
                Wifi = Wifi

            };
            Services.OtelService.InsertNewOtel(dto);
            TempData["Status"] = "succes";
            return Redirect("/Home/Index");
        }

        public ActionResult Kullanici()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Kaydol(UserDto form)
        {
            Services.UserService.Create(form);
            return Redirect("/Home/");
        }

        public ActionResult SingIn(UserDto form)
        {
            var kullanici = Services.UserService.GetByDto(form);
            if (kullanici != null)
            {
                Session.Add("Id", kullanici.Id);
                Session.Add("Name", kullanici.Name);
                Session.Add("DisplayName", kullanici.DisplayName);
                Session.Add("Email", kullanici.Email);
                Session.Add("Image", kullanici.Image);
                Session.Add("Authority", kullanici.AuthorityId);
                Session.Add("OtelId", kullanici.OtelId);
                Session.Add("Description", kullanici.Description);
                return Redirect("/Home/");
            }
            return Redirect("/Home/");
        }

    }
}