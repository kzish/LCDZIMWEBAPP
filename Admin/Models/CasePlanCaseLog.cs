using System;
using System.Collections.Generic;

namespace Admin.Models
{
    public partial class CasePlanCaseLog
    {
        public string Id { get; set; }
        public string CaseId { get; set; }
        public DateTime? Date { get; set; }
        public string ActionTakenActivity { get; set; }
        public string Outcome { get; set; }
        public string AttendingPerson { get; set; }
    }
}
