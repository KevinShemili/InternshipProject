using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities {
    public class Loan {
        public Guid LoanId { get; set; }
        public int RequestedAmount { get; set; }
        public decimal ReferenceRate { get; set; }
        public decimal InterestRate { get; set; }
        public int Tenor { get; set; }
        public string Status { get; set; } = null!;
        public Guid LenderId { get; set; }
        public Guid ApplicationId { get; set; }
    }
}
