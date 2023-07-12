using Application.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Authentication
{
    public interface IJwtToken
    {
        public string GenerateToken(TokenDto tokenDto);
    }
}
