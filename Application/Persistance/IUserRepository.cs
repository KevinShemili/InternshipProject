using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Persistance {
    public interface IUserRepository : IBaseRepository<User> {
        public User GetUserByUsername(string Username);
    }
}
