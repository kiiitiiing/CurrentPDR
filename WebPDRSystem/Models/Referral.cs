using System;
using System.Collections.Generic;

namespace WebPDRSystem.Models
{
    public partial class Referral
    {
        public int Id { get; set; }
        public DateTime DateOfReferral { get; set; }
        public string ReferringQuarantineFacility { get; set; }
        public string ReferredTo { get; set; }
        public int Pdrid { get; set; }
        public string PertinentFindings { get; set; }
        public string Diagnosis { get; set; }
        public string Reason { get; set; }
        public int ReferredBy { get; set; }

        public virtual Pdr Pdr { get; set; }
        public virtual Pdrusers ReferredByNavigation { get; set; }
    }
}
