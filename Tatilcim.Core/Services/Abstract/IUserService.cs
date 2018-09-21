using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatilcim.Common.Dtos;
using Tatilcim.Domain.Concrate;

namespace Tatilcim.Core.Services.Abstract
{
    public interface IUserService
    {
        List<UserDto> Get();
        List<UserDto> GetActive();
        UserDto GetByName(UserDto entityDto);
        void InsertNew(UserDto entityDto);
        void Update(UserDto entityDto);
        void Delete(UserDto entityDto);
    }
}
