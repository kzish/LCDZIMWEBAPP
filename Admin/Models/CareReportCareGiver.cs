using System;
using System.Collections.Generic;

namespace Admin.Models
{
    public partial class CareReportCareGiver
    {
        public string Id { get; set; }
        public string CaseId { get; set; }
        public string CareGiverName { get; set; }
        public DateTime? CareGiverDob { get; set; }
        public string CareGiverSex { get; set; }
        public string CareGiverPhoneNumber { get; set; }
        public string CareGiverAddress { get; set; }

        public virtual CaseReport Case { get; set; }
    }
}
