using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Services {
    public interface IHasherService {
        public bool VerifyPassword(string inputPassword, string passwordHash, string passwordSalt);
        public Tuple<string, string> HashPassword(string password);
    }
}
