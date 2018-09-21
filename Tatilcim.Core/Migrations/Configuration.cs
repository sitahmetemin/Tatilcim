using Tatilcim.Domain.Concrate;

namespace Tatilcim.Core.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Tatilcim.Core.TatilcimContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Tatilcim.Core.TatilcimContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Authorities.Add(new Authority()
            {
                Id =1,
                Command = "SuperAdmin",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                
            });
            context.Authorities.Add(new Authority()
            {
                Id = 2,
                Command = "Admin",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,

            });
            context.Authorities.Add(new Authority()
            {
                Id = 3,
                Command = "Costumer",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,

            });

            context.Users.Add(new User()
            {
                Id = 1,
                AuthorityId = 1,
                Description = "Sistem SüperAdmini",
                DisplayName = "sitahmetemin",
                Name = "Ahmet Emin ÞÝT",
                Email = "sitahmetemin@gmail.com",
                Password = "123654",
                Image = "https://mbtskoudsalg.com/images/profile-avatar-png-4.png",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            });

            context.Otels.Add(new Otel()
            {
                Name = "Grand Kaptan",
                Address = "Alanya",
                Description = "Otel Açýklamasý",
                Email = "otel@otel.com",
                Bar = "on",
                Breakfast = "on",
                CarPark = "on",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Cover = "https://cdn.tatilbudur.net/otel/960x475/grand-kaptan-hotel_185131.jpg",
                Star = 2,
                Status = true,
                Tel = "0212 212 12 12"
            });

            context.Otels.Add(new Otel()
            {
                Name = "KAplýcalar",
                Address = "Muðla",
                Description = "Otel Açýklamasý",
                Email = "otel@otel.com",
                Bar = "on",
                Breakfast = "on",
                CarPark = "on",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Cover = "https://cdn.tatilbudur.net/otel/960x475/grand-kaptan-hotel_185129.jpg",
                Star = 2,
                Status = true,
                Tel = "0212 212 12 12"
            });

            context.Otels.Add(new Otel()
            {
                Name = "KApalý Otel",
                Address = "artvin",
                Description = "ooo comolokko",
                Email = "otel@otel.com",
                Bar = "on",
                Breakfast = "on",
                CarPark = "on",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Cover = "https://cdn.tatilbudur.net/otel/960x475/grand-kaptan-hotel_185129.jpg",
                Star = 2,
                Status = false,
                Tel = "0212 212 12 12"
            });

        }
    }
}
