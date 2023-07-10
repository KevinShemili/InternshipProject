using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities {
    public class ProductMatrices {
        public Guid FileId { get; set; }
        public string FileName { get; set; } = null!;
    }
}
