using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatilcim.Common.General;

namespace Tatilcim.Common.Dtos
{
    public class UserDto : BaseDto
    {
        public UserDto()
        {
            this.Otel = new OtelDto();
        }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int? OtelId { get; set; }
        public int? AuthorityId { get; set; }

        public virtual OtelDto Otel { get; set; }


    }
}
