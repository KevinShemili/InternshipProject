using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities {
    public class Product {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string ProductDescription { get; set; } = null!;
        public decimal ReferenceRate { get; set; } 
        public int FinanceMaxAmount { get; set; }
        public int FinanceMinAmount { get; set; }
        public Guid ApplicationId { get; set; }
    }
}
