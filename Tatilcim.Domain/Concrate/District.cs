using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatilcim.Domain.Abstract;

namespace Tatilcim.Domain.Concrate
{
    public class District: BaseEntity
    {

        public string Name { get; set; }

        public Nullable<int> ProvinceId { get; set; }
        public virtual Province Province{ get; set; }
    }
}
