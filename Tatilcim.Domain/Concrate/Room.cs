using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatilcim.Domain.Abstract;

namespace Tatilcim.Domain.Concrate
{
    public class Room :BaseEntity
    {
        public Room()
        {
            this.Reservations = new HashSet<Reservation>();
            this.Albums = new HashSet<Album>();
        }
        public string Name { get; set; }
        public string Cover { get; set; }
        public decimal Price { get; set; }
        public int PersonCount { get; set; }
        public string Tel { get; set; }
        public string TV { get; set; }
        public string Clima { get; set; }
        public string MiniBar { get; set; }
        public string Jakuzi { get; set; }
        public string Balcony { get; set; }
        public string Bathroom { get; set; }
        public string Dryer { get; set; }

        public Nullable<int> OtelId { get; set; }
        public virtual Otel Otel { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
        public ICollection<Album> Albums { get; set; }
    }
}
