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
        public decimal Price { get; set; }
        public int PersonCount { get; set; }
        public bool Tel { get; set; }
        public bool TV { get; set; }
        public bool Clima { get; set; }
        public bool MiniBar { get; set; }
        public bool Jakuzi { get; set; }
        public bool Balcony { get; set; }
        public bool Bathroom { get; set; }
        public bool Dryer { get; set; }

        public Nullable<int> OtelId { get; set; }
        public virtual Otel Otel { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
        public ICollection<Album> Albums { get; set; }
    }
}
