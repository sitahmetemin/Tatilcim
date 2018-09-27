using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using ServiceStack;
using ServiceStack.Text.Common;
using Tatilcim.Common.Dtos;

namespace Tatilcim.UI.Controllers
{
    public class ReserveController : Controller
    {
        [HttpPost]
        public ActionResult AddReservaion(ReservationDto reservation)
        {
            reservation.CreatedAt = DateTime.Now;
            reservation.UpdatedAt = DateTime.Now;
            reservation.Status = false;
            var queueName = "Reservation-" + reservation.OtelId;

            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (IConnection connection = factory.CreateConnection())
            using (IModel channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: queueName,
                    durable: false,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null);

                string objem = JsonConvert.SerializeObject(reservation);
                var body = Encoding.UTF8.GetBytes(objem);
                channel.BasicPublish(exchange: "",
                    routingKey: queueName,
                    basicProperties: null,
                    body: body);
                
            }



            return Redirect("/Detail/Otel/"+reservation.OtelId);
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