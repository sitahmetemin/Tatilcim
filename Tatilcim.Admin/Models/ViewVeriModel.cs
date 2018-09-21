using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tatilcim.Domain.Concrate;

namespace Tatilcim.Admin.Models
{
    public class ViewVeriModel
    {
        public IEnumerable<Otel> Otel { get; set; }
        public IEnumerable<User> User { get; set; }
        public IEnumerable<Reservation> Reservation { get; set; }
        public IEnumerable<Authority> Authorities { get; set; }
    }
}