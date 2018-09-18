using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatilcim.Domain.Concrate;

namespace Tatilcim.Core
{
    class TatilcimContext : DbContext
    {
        public TatilcimContext() : base("TatilcimContextString")
        {
            
        }

        public DbSet<Authority> Authorities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Otel> Otels { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }
    }
}