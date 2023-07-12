using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Authentication.Common {
    public class LoginResult {
        public Guid Id { get; set; }
        public string Token { get; set; } = null!;
    }
}
