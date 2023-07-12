using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Authentication.Common
{
    public class TokenRequest {
        public Guid Id { get; set; }
        public string Username { get; set; } = null!;
    }
}
