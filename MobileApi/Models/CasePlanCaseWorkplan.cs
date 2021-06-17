﻿using System;
using System.Collections.Generic;

namespace MobileApi.Models
{
    public partial class CasePlanCaseWorkplan
    {
        public string Id { get; set; }
        public string CaseId { get; set; }
        public string ActionToBeTaken { get; set; }
        public DateTime? Date { get; set; }
        public string Responsibility { get; set; }
        public bool? Done { get; set; }

        public virtual CaseReport Case { get; set; }
    }
}
