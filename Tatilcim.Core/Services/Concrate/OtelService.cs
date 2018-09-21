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
    class OtelService : IOtelService
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
                return _repo.Query<Otel>().Where(x => x.DeletedAt != null && x.Status == true).ToList();
            }
        }

        public OtelDto GetOtelByName(OtelDto otel)
        {
            throw new NotImplementedException();
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
                Cover = otel.CarPark,
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

        public void UpdateOtel(OtelDto otel)
        {
            throw new NotImplementedException();
        }

        public void DeleteOtel(OtelDto otel)
        {
            throw new NotImplementedException();
        }
    }
}
