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

            context.Authorities.AddOrUpdate(new Authority()
            {
                Id = 1,
                Command = "SuperAdmin",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,

            });
            context.Authorities.AddOrUpdate(new Authority()
            {
                Id = 2,
                Command = "Admin",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,

            });
            context.Authorities.AddOrUpdate(new Authority()
            {
                Id = 3,
                Command = "Costumer",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,

            });

            context.Otels.AddOrUpdate(new Otel()
            {
                Name = "Grand Kaptan",
                Address = "Alanya",
                Description = "Otel Açıklaması Burada",
                Email = "otel1@otel.com",
                Bar = "on",
                Breakfast = "on",
                CarPark = "on",
                Gym = "on",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Cover = "https://cdn.tatilbudur.net/otel/960x475/grand-kaptan-hotel_185131.jpg",
                Star = 2,
                Status = true,
                Tel = "0212 212 12 12"
            });

            context.Otels.AddOrUpdate(new Otel()
            {
                Name = "Kaplıcalar",
                Address = "Muğla",
                Description = "Otel Açıklaması Kardeşim",
                Email = "otel2@otel.com",
                Bar = "on",
                Breakfast = "on",
                CarPark = "on",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Cover = "https://cdn.tatilbudur.net/otel/960x475/grand-kaptan-hotel_185129.jpg",
                Star = 5,
                Status = true,
                Tel = "0212 212 12 12"
            });

            context.Otels.AddOrUpdate(new Otel()
            {
                Name = "Kapalı Otel",
                Address = "Artvin",
                Description = "ooo comolokko",
                Email = "otel3@otel.com",
                Bar = "on",
                CarPark = "on",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Cover = "https://cdn.tatilbudur.net/otel/960x475/grand-kaptan-hotel_185129.jpg",
                Star = 8,
                Status = false,
                Tel = "0282 339 85 08"
            });

            context.Users.AddOrUpdate(new User()
            {
                Id = 1,
                AuthorityId = 1,
                Description = "Sistem SüperAdmini",
                DisplayName = "sitahmetemin",
                Name = "Ahmet Emin ŞİT",
                Email = "sitahmetemin@gmail.com",
                Password = "123654",
                Image = "https://mbtskoudsalg.com/images/profile-avatar-png-4.png",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            });

            context.Users.AddOrUpdate(new User()
            {
                Id = 1,
                AuthorityId = 2,
                Description = "Otel Sahibi",
                DisplayName = "ahmeteminsit",
                Name = "Ahmet Zade",
                OtelId = 1,
                Email = "sitahmetemin@hotmail.com",
                Password = "123654",
                Image = "https://www.mac-hotels.com/wp-content/blogs.dir/1262/files/Homeymas/home_mini_marina-1.jpg.pagespeed.ce.-LQmHg6YCg.jpg",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            });

            context.Users.AddOrUpdate(new User()
            {
                Id = 1,
                AuthorityId = 3,
                Description = "Müşteri",
                DisplayName = "fitifiti",
                Name = "Fıtıfıtı",
                Email = "sitahmetemin@yandex.com",
                Password = "123654",
                Image = "https://www.mac-hotels.com/wp-content/blogs.dir/1262/files/Homeymas/home_mini_marina-1.jpg.pagespeed.ce.-LQmHg6YCg.jpg",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            });

        }
    }
}
