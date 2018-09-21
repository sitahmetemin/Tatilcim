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
            this.Albums = new HashSet<Album>();
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string Tel { get; set; }
        public int Star { get; set; }
        public string Cover { get; set; }
        public bool Status { get; set; }
        public string CarPark { get; set; }
        public string Restaurant { get; set; }
        public string Bar { get; set; }
        public string Spa { get; set; }
        public string Pool { get; set; }
        public string Gym { get; set; }
        public string RoomService { get; set; }
        public string Breakfast { get; set; }
        public string Wifi { get; set; }


        public ICollection<Room> Rooms { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        public ICollection<Album> Albums { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
