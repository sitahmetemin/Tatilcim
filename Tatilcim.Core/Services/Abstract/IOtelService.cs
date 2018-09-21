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
        OtelDto GetOtelByName(OtelDto otel);
        void InsertNewOtel(OtelDto otel);
        void UpdateOtel(OtelDto otel);
        void DeleteOtel(OtelDto otel);
    }
}
