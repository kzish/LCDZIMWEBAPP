using System;
using System.Collections.Generic;

namespace Admin.Models
{
    public partial class CaseReportParentsGuardiansSpousesInformation
    {
        public string Id { get; set; }
        public string CaseId { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Occupation { get; set; }
        public string Employer { get; set; }
        public string MaritalStatus { get; set; }
        public string MaritalStatusOtherSpecify { get; set; }

        public virtual CaseReport Case { get; set; }
    }
}
