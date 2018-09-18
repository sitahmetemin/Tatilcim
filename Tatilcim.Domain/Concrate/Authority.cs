using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatilcim.Domain.Abstract;

namespace Tatilcim.Domain.Concrate
{
    public class Authority :BaseEntity
    {
        public Authority()
        {
            this.Users = new HashSet<User>();
        }

        public string Command { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
