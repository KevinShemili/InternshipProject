using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities {
    public class Application {
        public Guid ApplicationId { get; set; }
        public string ApplicationName { get; set; } = null!;
        public int RequestedAmount { get; set; }
        public int RequestedTenor { get; set; }
        public string FinancePurposeDefinition { get; set; } = null!;
        public string ApplicationStatus { get; set; } = null!;
        public Guid BorrowerId { get; set; }
        public Guid FileId { get; set; }
    }
}
