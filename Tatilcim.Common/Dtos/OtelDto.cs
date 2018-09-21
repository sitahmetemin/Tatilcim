using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatilcim.Common.General;

namespace Tatilcim.Common.Dtos
{
    public class OtelDto : BaseDto
    {
        public OtelDto()
        {
            
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

        //public ICollection<Room> Rooms { get; set; }
        //public ICollection<Reservation> Reservations { get; set; }
        //public ICollection<Album> Albums { get; set; }
    }
}
