using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Common
{
    public class TokenDto
    {
        public Guid Id { get; set; } 
        public string Username { get; set; } = null!;
    }
}
