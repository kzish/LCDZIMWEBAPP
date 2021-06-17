using System;
using System.Collections.Generic;

namespace Admin.Models
{
    public partial class CaseReportCasePlanAndFollowUp
    {
        public string Id { get; set; }
        public string CaseId { get; set; }
        public string StageCaseRefered { get; set; }
        public string ActionTakenByAnyoneDateThisFormWasCompleted { get; set; }
        public string AnyOtherImportantNotes { get; set; }
        public string StateOtherNeedsOfTheBeneficiaryForReferalToOtherServiceProviders { get; set; }
        public string CompiledBy { get; set; }
        public string ApprovedBy { get; set; }
        public string ApprovedBySignature { get; set; }
        public DateTime? Date { get; set; }

        public virtual CaseReport Case { get; set; }
    }
}
