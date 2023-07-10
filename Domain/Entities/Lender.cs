using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities {
    public class Lender {
        public Guid LenderId { get; set; }
        public string LenderName { get; set; } = null!;
        public int RequestedAmount { get; set; }
        public int Tenor { get; set; }
        public string BorrowerCompanyType { get; set; } = null!;
    }
}
