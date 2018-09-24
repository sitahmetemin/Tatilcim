using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatilcim.Common.Dtos;
using Tatilcim.Domain.Concrate;

namespace Tatilcim.Core.Services
{
    public interface IOtelService
    {
        List<Otel> GetOtels();
        List<Otel> GetActiveOtels();
        List<OtelDto> GetActiveRandomOtels();
        OtelDto GetOtelByName(OtelDto otel);
        List<OdaDto> GetRooms(OtelDto Otel);
        void InsertNewOtel(OtelDto otel);
        void InsertNewRoom(OdaDto Oda);
        void UpdateOtel(OtelDto otel);
        void DeleteOtel(OtelDto otel);
        void DeleteRoom(OdaDto oda);
    }
}
