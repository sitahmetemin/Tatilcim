using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatilcim.Domain.Abstract;

namespace Tatilcim.Domain.Concrate
{
    public class Province :BaseEntity
    {
        public Province()
        {
            this.Districts = new HashSet<District>();
        }
        public string Name { get; set; }

        public ICollection<District> Districts { get; set; }
    }
}
