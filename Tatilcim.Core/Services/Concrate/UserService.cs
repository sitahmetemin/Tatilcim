using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatilcim.Common.Dtos;
using Tatilcim.Core.Repository;
using Tatilcim.Core.Services.Abstract;
using Tatilcim.Domain.Concrate;

namespace Tatilcim.Core.Services.Concrate
{
    public class UserService: IBaseServices<UserDto>
    {
        public List<UserDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<UserDto> GetActiveAll()
        {
            throw new NotImplementedException();
        }

        public UserDto GetByDto(UserDto entityDto)
        {
            using (BaseRepository<User> _repo = new BaseRepository<User>())
            {
                var kullanici = _repo.Query<User>().FirstOrDefault(x => x.DisplayName == entityDto.DisplayName && x.Password == entityDto.Password && x.DeletedAt == null);
                if (kullanici !=null)
                {
                    entityDto.Id = kullanici.Id;
                    entityDto.Name = kullanici.Name;
                    entityDto.DisplayName = kullanici.DisplayName;
                    entityDto.Email = kullanici.Email;
                    entityDto.Image = kullanici.Image;
                    entityDto.Description = kullanici.Description;
                    entityDto.OtelId = kullanici.OtelId;
                    entityDto.AuthorityId = kullanici.AuthorityId;

                    return entityDto;
                }
                return null;
            }
        }

        public UserDto GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Create(UserDto entityDto)
        {
            using (BaseRepository<User> _repo = new BaseRepository<User>())
            {
                User usr = new User()
                {
                    AuthorityId = 3,
                    Name = entityDto.Name,
                    Email = entityDto.Email,
                    Password = entityDto.Password,
                    DisplayName = entityDto.DisplayName,
                    Description = entityDto.Description,
                    Image = entityDto.Image,
                };
                _repo.Add(usr);

            }
        }

        public void Update(UserDto entityDto)
        {
            throw new NotImplementedException();
        }

        public void Delete(UserDto entityDto)
        {
            throw new NotImplementedException();
        }

        public void SoftDelete(UserDto entityDto)
        {
            throw new NotImplementedException();
        }
    }
}
