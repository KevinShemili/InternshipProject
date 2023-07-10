﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities {
    public class Permissions {
        public Guid PermissionId { get; set; }    
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
    }
}