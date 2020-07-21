using System;
using System.Collections.Generic;

namespace WebPDRSystem.Models
{
    public partial class Pdr
    {
        public Pdr()
        {
            Discharge = new HashSet<Discharge>();
            DoctorOrders = new HashSet<DoctorOrders>();
            LabResult = new HashSet<LabResult>();
            Qdform = new HashSet<Qdform>();
            Qnform = new HashSet<Qnform>();
            Referral = new HashSet<Referral>();
            Unusualities = new HashSet<Unusualities>();
        }

        public int Id { get; set; }
        public DateTime? DateOfAdmission { get; set; }
        public string ReferringFacility { get; set; }
        public string QuarantineFacility { get; set; }
        public string CaseNumber { get; set; }
        public string BedNumber { get; set; }
        public int? Patient { get; set; }
        public string Pdrcode { get; set; }
        public int? Guardian { get; set; }
        public DateTime? DateTesting { get; set; }
        public string Results { get; set; }
        public string History { get; set; }
        public string TravelHistory { get; set; }
        public DateTime? DateOnsetSymptoms { get; set; }
        public string PreExistingConditions { get; set; }
        public string Maintenance { get; set; }
        public bool? MayGoHome { get; set; }
        public string FoodRestrictionsAllergy { get; set; }
        public string AdmissionTemperature { get; set; }
        public bool AdmittedSotto { get; set; }
        public int? InterviewedBy { get; set; }
        public string Status { get; set; }
        public int? SymptomsContactsId { get; set; }
        public bool Attended { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Guardian GuardianNavigation { get; set; }
        public virtual Pdrusers InterviewedByNavigation { get; set; }
        public virtual Patient PatientNavigation { get; set; }
        public virtual SymptomsContacts SymptomsContacts { get; set; }
        public virtual ICollection<Discharge> Discharge { get; set; }
        public virtual ICollection<DoctorOrders> DoctorOrders { get; set; }
        public virtual ICollection<LabResult> LabResult { get; set; }
        public virtual ICollection<Qdform> Qdform { get; set; }
        public virtual ICollection<Qnform> Qnform { get; set; }
        public virtual ICollection<Referral> Referral { get; set; }
        public virtual ICollection<Unusualities> Unusualities { get; set; }
    }
}
