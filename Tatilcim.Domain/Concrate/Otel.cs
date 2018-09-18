using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatilcim.Domain.Abstract;

namespace Tatilcim.Domain.Concrate
{
    public class Otel : BaseEntity
    {
        public Otel()
        {
            this.Rooms = new HashSet<Room>();
            this.Reservations = new HashSet<Reservation>();
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string Tel { get; set; }
        public string Yıldız { get; set; }
        public bool CarPark { get; set; }
        public bool Restaurant { get; set; }
        public bool Bar { get; set; }
        public bool Spa { get; set; }
        public bool Pool { get; set; }
        public bool Gym { get; set; }
        public bool RoomService { get; set; }
        public bool Breakfast { get; set; }
        public bool Wifi { get; set; }

        public ICollection<Room> Rooms { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
