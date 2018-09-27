using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatilcim.Common.Dtos;
using Tatilcim.Core.Repository;
using Tatilcim.Domain.Concrate;

namespace Tatilcim.Core.Services.Concrate
{
    public class OtelService : IOtelService
    {
        public List<Otel> GetOtels()
        {
            using (BaseRepository<Otel> _repo = new BaseRepository<Otel>())
            {
                return _repo.Query<Otel>().Where(x => x.DeletedAt != null).ToList();
            }
        }

        public List<Otel> GetActiveOtels()
        {
            using (BaseRepository<Otel> _repo = new BaseRepository<Otel>())
            {
                return _repo.Query<Otel>().Where(x => x.DeletedAt != null && x.Status).ToList();
            }
        }

        public List<OtelDto> GetActiveRandomOtels()
        {
            BaseRepository<Otel> _repo = new BaseRepository<Otel>();
            Random rnd = new Random();
            var atla = rnd.Next();
            var DBotel = _repo.Query<Otel>().Where(x => x.DeletedAt == null && x.Status == true)
                .ToList();
                //.OrderBy(otel => otel.Id < atla)
            List<OtelDto> odaBilgiler = new List<OtelDto>();
            foreach (var room in DBotel)
            {
                odaBilgiler.Add(new OtelDto
                {
                    Id = room.Id,
                    Name = room.Name,
                    Description = room.Description,
                    Email = room.Email,
                    Restaurant = room.Restaurant,
                    Address = room.Address,
                    Bar = room.Bar,
                    Breakfast = room.Breakfast,
                    CarPark = room.CarPark,
                    Cover = room.Cover,
                    Gym = room.Gym,
                    Pool = room.Pool,
                    RoomService = room.RoomService,
                    Spa = room.Spa,
                    Star = room.Star,
                    Tel = room.Tel,
                    Status = room.Status,
                    Wifi = room.Wifi
                });
            }

            return odaBilgiler;
        }

        public OtelDto GetOtelByName(OtelDto otel)
        {
            using (BaseRepository<Otel> _repo = new BaseRepository<Otel>())
            {
                var DBotel = _repo.Query<Otel>().FirstOrDefault(x => x.Id == otel.Id);
                OtelDto otelBilgiler = new OtelDto()
                {
                    Id = DBotel.Id,
                    Name = DBotel.Name,
                    Description = DBotel.Description,
                    Email = DBotel.Email,
                    Restaurant = DBotel.Restaurant,
                    Address = DBotel.Address,
                    Bar = DBotel.Bar,
                    Breakfast = DBotel.Breakfast,
                    CarPark = DBotel.CarPark,
                    Cover = DBotel.Cover,
                    Gym = DBotel.Gym,
                    Pool = DBotel.Pool,
                    RoomService = DBotel.RoomService,
                    Spa = DBotel.Spa,
                    Star = DBotel.Star,
                    Tel = DBotel.Tel,
                    Status = DBotel.Status,
                    Wifi = DBotel.Wifi
                };
                return otelBilgiler;
            }
        }

        public List<OdaDto> GetRooms(OtelDto otel)
        {
            BaseRepository<Room> _repo = new BaseRepository<Room>();

            var DBotel = _repo.Query<Room>().Where(x => x.OtelId == otel.Id).ToList();
            List<OdaDto> odaBilgiler = new List<OdaDto>();
            foreach (var room in DBotel)
            {
                odaBilgiler.Add(new OdaDto()
                {
                    Id = room.Id,
                    Name = room.Name,
                    OtelId = room.OtelId,
                    Balcony = room.Balcony,
                    Price = room.Price,
                    PersonCount = room.PersonCount,
                    Tel = room.Tel,
                    TV = room.TV,
                    Clima = room.Clima,
                    MiniBar = room.MiniBar,
                    Jakuzi = room.Jakuzi,
                    Bathroom = room.Bathroom,
                    Dryer = room.Dryer,
                    Cover = room.Cover
                });
            }

            return odaBilgiler;
        }

        public void InsertNewOtel(OtelDto otel)
        {
            Otel otelBilgiler = new Otel()
            {
                Name = otel.Name,
                Description = otel.Description,
                Email = otel.Email,
                Restaurant = otel.Restaurant,
                Address = otel.Address,
                Bar = otel.Bar,
                Breakfast = otel.Breakfast,
                CarPark = otel.CarPark,
                Cover = otel.Cover,
                Gym = otel.Gym,
                Pool = otel.Pool,
                RoomService = otel.RoomService,
                Spa = otel.Spa,
                Star = otel.Star,
                Tel = otel.Tel,
                Status = otel.Status,
                Wifi = otel.Wifi
            };
            using (BaseRepository<Otel> _repo = new BaseRepository<Otel>())
            {
                _repo.Add(otelBilgiler);
            }
        }

        public void InsertNewRoom(OdaDto Oda)
        {
            Room otelBilgiler = new Room()
            {
                Name = Oda.Name,
                Price = Oda.Price,
                PersonCount = Oda.PersonCount,
                Tel = Oda.Tel,
                TV = Oda.TV,
                Clima = Oda.Clima,
                MiniBar = Oda.MiniBar,
                Jakuzi = Oda.Jakuzi,
                Balcony = Oda.Balcony,
                Bathroom = Oda.Bathroom,
                Dryer = Oda.Dryer,
                OtelId = Oda.OtelId,
                Cover = Oda.Cover
            };
            using (BaseRepository<Room> _repo = new BaseRepository<Room>())
            {
                _repo.Add(otelBilgiler);
            }
        }

        public void UpdateOtel(OtelDto otel)
        {
            throw new NotImplementedException();
        }

        public void DeleteOtel(OtelDto otel)
        {
            throw new NotImplementedException();
        }

        public void DeleteRoom(OdaDto oda)
        {
            using (BaseRepository<Room> _repo = new BaseRepository<Room>())
            {
                var bilgiler = _repo.Query<Room>().FirstOrDefault(x => x.Id == oda.Id);
                _repo.Delete(bilgiler);
            }
        }
    }
}