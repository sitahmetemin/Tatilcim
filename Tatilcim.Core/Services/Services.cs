using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatilcim.Common.Dtos;
using Tatilcim.Core.Services.Abstract;
using Tatilcim.Core.Services.Concrate;

namespace Tatilcim.Core.Services
{
    public class Services
    {
        public static IOtelService OtelService
        {
            get
            {
                return (IOtelService)new OtelService();
            }
        }

        public static IBaseServices<UserDto> UserService
        {
            get
            {
                return (IBaseServices<UserDto>)new UserService();
            }
        }

        public static IElasticServices ElasticServices
        {
            get
            {
                return (IElasticServices)new ElasticSearchService();
            }
        }
    }
}
