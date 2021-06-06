using System;
using System.Collections.Generic;

namespace MobileApi.Models
{
    public partial class CaseReport
    {
        public CaseReport()
        {
            CaseReportClientInformation = new HashSet<CaseReportClientInformation>();
            CaseReportDescriptionOfTheCaseProblem = new HashSet<CaseReportDescriptionOfTheCaseProblem>();
            CaseReportNeedsAssesment = new HashSet<CaseReportNeedsAssesment>();
            CaseReportNextOfKin = new HashSet<CaseReportNextOfKin>();
            CaseReportParentsGuardiansSpousesInformation = new HashSet<CaseReportParentsGuardiansSpousesInformation>();
        }

        public string Id { get; set; }
        public DateTime? Date { get; set; }
        public string ReferredByNameAndInstitution { get; set; }
        public string PoliceStation { get; set; }
        public string CrRef { get; set; }
        public string NameOfInvestigatingOfficer { get; set; }
        public string MobileNumber { get; set; }
        public string CourtHandlingTheCase { get; set; }
        public DateTime? DateCaseWasReported { get; set; }
        public string ForceNumber { get; set; }
        public string CompiledBy { get; set; }
        public DateTime? DateCompiled { get; set; }

        public virtual ICollection<CaseReportClientInformation> CaseReportClientInformation { get; set; }
        public virtual ICollection<CaseReportDescriptionOfTheCaseProblem> CaseReportDescriptionOfTheCaseProblem { get; set; }
        public virtual ICollection<CaseReportNeedsAssesment> CaseReportNeedsAssesment { get; set; }
        public virtual ICollection<CaseReportNextOfKin> CaseReportNextOfKin { get; set; }
        public virtual ICollection<CaseReportParentsGuardiansSpousesInformation> CaseReportParentsGuardiansSpousesInformation { get; set; }
    }
}
