
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities {
    public class CompanyType {
        public Guid CompanyTypeId { get; set; }
        public string Type { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
