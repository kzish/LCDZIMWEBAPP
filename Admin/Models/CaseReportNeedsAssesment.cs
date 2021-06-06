using System;
using System.Collections.Generic;

namespace Admin.Models
{
    public partial class CaseReportNeedsAssesment
    {
        public string Id { get; set; }
        public string CaseId { get; set; }
        public string WhereDoesTheBeneficiaryLive { get; set; }
        public string WhoIsTakingCareOfTheBeneficiary { get; set; }
        public string WhoIsTakingCareOfTheBeneficiaryOtherSpecify { get; set; }
        public int? HowManyPeopleLiveWithTheBeneficiary { get; set; }
        public string HowManyPeopleLiveWithTheBeneficiaryRelation { get; set; }
        public bool? IsTheBeneficiaryAbleToVerballyCommunicate { get; set; }
        public string IfNoHowDoesHeSheCommunicate { get; set; }
        public bool? IsTheBeneficiaryAbleToMoveIndependently { get; set; }
        public string IfNotWhatAssistanceIsNeededMovement { get; set; }
        public string BeneficiaryWellBeingAtThePointOfIntake { get; set; }
        public string BeneficiaryWellBeingAtThePointOfIntakeOtherSpecify { get; set; }
        public string BeneficiaryImmediateConcerns { get; set; }
        public string OtherRelevantIssues { get; set; }

        public virtual CaseReport Case { get; set; }
    }
}
