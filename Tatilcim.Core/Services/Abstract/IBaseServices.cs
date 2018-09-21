using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatilcim.Core.Services.Abstract
{
    public interface IBaseServices<T>
    {
        List<T> GetAll();
        List<T> GetActiveAll();
        T GetByDto(T entityDto);
        T GetById(int Id);
        void Create(T entityDto);
        void Update(T entityDto);
        void Delete(T entityDto);
        void SoftDelete(T entityDto);
    }
}
