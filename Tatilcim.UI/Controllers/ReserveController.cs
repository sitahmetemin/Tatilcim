using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Tatilcim.Common.Dtos;

namespace Tatilcim.UI.Controllers
{
    public class ReserveController : Controller
    {
        [HttpPost]
        public JsonResult AddReservaion(int GelenOtelId, int GelenRoomId, DateTime GirisTarihi, DateTime CikisTarihi, int KisiSayisi)
        {
            ReservationDto reservation = new ReservationDto()
            {
                OtelId = GelenOtelId,
                RoomId = GelenRoomId,
                EntryDate = GirisTarihi,
                ReleaseDate = CikisTarihi,
                PersonCount = KisiSayisi,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (IConnection connection = factory.CreateConnection())
            using (IModel channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "Reservation",
                    durable: false,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null);
               
                string serializeReservation = JsonConvert.SerializeObject(reservation);
                var content = Encoding.UTF8.GetBytes(serializeReservation);

                channel.BasicPublish(exchange: "",
                    routingKey: "Reservation",
                    basicProperties: null,
                    body: content);
            }

            return Json("succes", JsonRequestBehavior.AllowGet);
        }


        public ActionResult GetReservation()
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (IConnection connection = factory.CreateConnection())
            using (IModel channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "Reservation",
                    durable: false,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null);

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    var message = Encoding.UTF8.GetString(body);
                    ReservationDto person = JsonConvert.DeserializeObject<ReservationDto>(message);
                };
                channel.BasicConsume(queue: "Reservation",
                    consumer: consumer);

                
            }

            return PartialView();
        }
    }
}