using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatilcim.Domain.Abstract;

namespace Tatilcim.Domain.Concrate
{
    public class Album: BaseEntity
    {
        public string Image { get; set; }

        public int? OtelId { get; set; }
        public virtual Otel Otel { get; set; }

        public int? RoomId { get; set; }
        public virtual Room Room { get; set; }
    }
}
