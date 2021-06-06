using System;
using System.Collections.Generic;

namespace Admin.Models
{
    public partial class CaseReportClientInformation
    {
        public int Id { get; set; }
        public int CaseId { get; set; }
        public string NameOfClient { get; set; }
        public DateTime Dob { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string LevelOfEducation { get; set; }
        public string ClientsAddress { get; set; }
        public string PhoneNumberHome { get; set; }
        public string Mobile { get; set; }
        public string DescriptionOfDisability { get; set; }
        public string GiveDetailsOfTheDisability { get; set; }

        public virtual CaseReport Case { get; set; }
    }
}
