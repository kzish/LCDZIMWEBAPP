using System;
using System.Collections.Generic;

namespace Admin.Models
{
    public partial class CaseReportDescriptionOfTheCaseProblem
    {
        public string Id { get; set; }
        public string CaseId { get; set; }
        public string BeneficiaryStatus { get; set; }
        public string BeneficiaryStatusOtherSpecify { get; set; }
        public string RelationshipClientAndAccused { get; set; }
        public string RelationshipClientAndWitness { get; set; }
        public string RelationshipClientAndSurvivorVictimComplainant { get; set; }
        public string NatureOfTheMatterCase { get; set; }
        public string NatureOfTheMatterCaseOtherSpecify { get; set; }
        public string DetailsOfCaseAndCharge { get; set; }

        public virtual CaseReport Case { get; set; }
    }
}
