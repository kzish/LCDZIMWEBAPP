using System;
using System.Collections.Generic;

namespace Admin.Models
{
    public partial class CaseReport
    {
        public CaseReport()
        {
            CareReportCareGiver = new HashSet<CareReportCareGiver>();
            CasePlanCaseLog = new HashSet<CasePlanCaseLog>();
            CasePlanCaseWorkplan = new HashSet<CasePlanCaseWorkplan>();
            CaseReportCasePlanAndFollowUp = new HashSet<CaseReportCasePlanAndFollowUp>();
            CaseReportClientInformation = new HashSet<CaseReportClientInformation>();
            CaseReportDescriptionOfTheCaseProblem = new HashSet<CaseReportDescriptionOfTheCaseProblem>();
            CaseReportJustificationReportForAttendedCases = new HashSet<CaseReportJustificationReportForAttendedCases>();
            CaseReportNeedsAssesment = new HashSet<CaseReportNeedsAssesment>();
            CaseReportNextOfKin = new HashSet<CaseReportNextOfKin>();
            CaseReportParentsGuardiansSpousesInformation = new HashSet<CaseReportParentsGuardiansSpousesInformation>();
            CaseReportPaymentsToBeneficiaries = new HashSet<CaseReportPaymentsToBeneficiaries>();
        }

        public string Id { get; set; }
        public DateTime? Date { get; set; }
        public string CaseNumber { get; set; }
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

        public virtual ICollection<CareReportCareGiver> CareReportCareGiver { get; set; }
        public virtual ICollection<CasePlanCaseLog> CasePlanCaseLog { get; set; }
        public virtual ICollection<CasePlanCaseWorkplan> CasePlanCaseWorkplan { get; set; }
        public virtual ICollection<CaseReportCasePlanAndFollowUp> CaseReportCasePlanAndFollowUp { get; set; }
        public virtual ICollection<CaseReportClientInformation> CaseReportClientInformation { get; set; }
        public virtual ICollection<CaseReportDescriptionOfTheCaseProblem> CaseReportDescriptionOfTheCaseProblem { get; set; }
        public virtual ICollection<CaseReportJustificationReportForAttendedCases> CaseReportJustificationReportForAttendedCases { get; set; }
        public virtual ICollection<CaseReportNeedsAssesment> CaseReportNeedsAssesment { get; set; }
        public virtual ICollection<CaseReportNextOfKin> CaseReportNextOfKin { get; set; }
        public virtual ICollection<CaseReportParentsGuardiansSpousesInformation> CaseReportParentsGuardiansSpousesInformation { get; set; }
        public virtual ICollection<CaseReportPaymentsToBeneficiaries> CaseReportPaymentsToBeneficiaries { get; set; }
    }
}
