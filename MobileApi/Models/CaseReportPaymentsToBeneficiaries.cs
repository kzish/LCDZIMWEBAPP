using System;
using System.Collections.Generic;

namespace MobileApi.Models
{
    public partial class CaseReportPaymentsToBeneficiaries
    {
        public string Id { get; set; }
        public string CaseId { get; set; }
        public DateTime? Date { get; set; }
        public string Purpose { get; set; }
        public string Program { get; set; }
        public string Name { get; set; }
        public string IdNumber { get; set; }
        public decimal? BusFare { get; set; }
        public decimal? Breakfast { get; set; }
        public decimal? Lunch { get; set; }
        public decimal? Dinner { get; set; }
        public decimal? Accomodation { get; set; }
        public decimal? PerDiem { get; set; }
        public decimal? Other { get; set; }
        public string SignatureOfRecipient { get; set; }
        public string ExpenseCode { get; set; }
        public string PaidByName { get; set; }
        public string PaidBySignature { get; set; }
        public DateTime? PaidByDate { get; set; }
        public string CheckedByName { get; set; }
        public string CheckedBySignature { get; set; }
        public DateTime? CheckedByDate { get; set; }
        public string AuthorisedByName { get; set; }
        public string AuthorisedBySignature { get; set; }
        public DateTime? AuthorisedByDate { get; set; }
    }
}
