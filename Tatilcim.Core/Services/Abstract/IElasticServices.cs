using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatilcim.Common.Dtos;

namespace Tatilcim.Core.Services.Abstract
{
    public interface IElasticServices
    {
        void CreateIndex();
        List<ElasticDto> Search(string key);
        List<ElasticDto> GetDto();
    }

    
}
