﻿using System;
using System.Collections.Generic;

namespace Admin.Models
{
    public partial class CasePlanCaseWorkplan
    {
        public string Id { get; set; }
        public string CasePlanId { get; set; }
        public string ActionToBeTaken { get; set; }
        public DateTime? Date { get; set; }
        public string Responsibility { get; set; }
        public bool? Done { get; set; }
    }
}
