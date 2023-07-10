﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities {
    public class CompanyProfile {
        public Guid ProfileId { get; set; }
        public string Country { get; set; } = null!;
        public string Currency { get; set; } = null!;
        public string Exchange { get; set; } = null!;
        public string IPO { get; set; } = null!;
        public int MarketCapitalization { get; set; }
        public string Name { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public decimal ShareOutstanding { get; set; }
        public string Ticker { get; set; } = null!;
        public string WebUrl { get; set; } = null!;
        public string Logo { get; set; } = null!;
        public string FinnhubIndustry { get; set; } = null!;
    }
}