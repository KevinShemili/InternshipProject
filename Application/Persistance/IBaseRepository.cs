using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Persistance {
    public interface IBaseRepository<T> {
        void Create(T entity);
        void Delete(int id);
        T GetById(int id);
    }
}
