using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities {
    public class Borrower {
        public Guid BorrowedId { get; set; }
        public string CompanyName { get; set; } = null!;
        public int VATNumber { get; set; }
        public int FiscalCode { get; set; }
        public Guid UserId { get; set; }
        public Guid CompanyTypeId { get; set; }
        public Guid ProfileId { get; set; }
    }
}
