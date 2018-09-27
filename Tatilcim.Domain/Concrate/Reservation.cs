using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatilcim.Domain.Abstract;

namespace Tatilcim.Domain.Concrate
{
    public class Reservation : BaseEntity
    {
        public int PersonCount { get; set; }
        public bool Status { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ReleaseDate { get; set; }

        public Nullable<int> UserId { get; set; }
        public virtual User User { get; set; }

        public Nullable<int> OtelId { get; set; }
        public virtual Otel Otel { get; set; }

        public Nullable<int> RoomId { get; set; }
        public virtual Room Room { get; set; }

    }
}
