using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatilcim.Domain.Abstract;

namespace Tatilcim.Domain.Concrate
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }


        public Nullable<int> AuthorityId { get; set; }
        public virtual Authority Authority { get; set; }
    }
}
