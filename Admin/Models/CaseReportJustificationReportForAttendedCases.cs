using System;
using System.Collections.Generic;

namespace Admin.Models
{
    public partial class CaseReportJustificationReportForAttendedCases
    {
        public string Id { get; set; }
        public string CaseId { get; set; }
        public string NameOfBeneficiary { get; set; }
        public string PlaceOfOriginResidence { get; set; }
        public string PlaceOfActivity { get; set; }
        public DateTime? DateWhenTheBeneficiaryWasAssisted { get; set; }
        public bool? TypeOfAssistanceLogisticalSupport { get; set; }
        public bool? TypeOfAssistanceDisabilityExpert { get; set; }
        public bool? TypeOfAssistanceHomeVisit { get; set; }
        public string SummaryOfActivity { get; set; }
        public string Outcome { get; set; }
        public DateTime? DateOfCourtHearing { get; set; }
        public string PreparedBy { get; set; }
        public DateTime? PreparedByDate { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedByDate { get; set; }

        public virtual CaseReport Case { get; set; }
    }
}
