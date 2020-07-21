using System;
using System.Collections.Generic;

namespace WebPDRSystem.Models
{
    public partial class Pdrusers
    {
        public Pdrusers()
        {
            CensusNodaNavigation = new HashSet<Census>();
            CensusNodbNavigation = new HashSet<Census>();
            CensusOdgNavigation = new HashSet<Census>();
            CensusOdrNavigation = new HashSet<Census>();
            CensusQdNavigation = new HashSet<Census>();
            DischargeDischargedByNavigation = new HashSet<Discharge>();
            DischargeHealthCareBuddyNavigation = new HashSet<Discharge>();
            DoctorOrders = new HashSet<DoctorOrders>();
            LabResult = new HashSet<LabResult>();
            Medications = new HashSet<Medications>();
            Pdr = new HashSet<Pdr>();
            Qdform = new HashSet<Qdform>();
            Qnform = new HashSet<Qnform>();
            Referral = new HashSet<Referral>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Facility { get; set; }
        public string Picture { get; set; }
        public string Initials { get; set; }
        public int? Team { get; set; }
        public string Role { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Schedule { get; set; }
        public string Designation { get; set; }

        public virtual UserTeams TeamNavigation { get; set; }
        public virtual ICollection<Census> CensusNodaNavigation { get; set; }
        public virtual ICollection<Census> CensusNodbNavigation { get; set; }
        public virtual ICollection<Census> CensusOdgNavigation { get; set; }
        public virtual ICollection<Census> CensusOdrNavigation { get; set; }
        public virtual ICollection<Census> CensusQdNavigation { get; set; }
        public virtual ICollection<Discharge> DischargeDischargedByNavigation { get; set; }
        public virtual ICollection<Discharge> DischargeHealthCareBuddyNavigation { get; set; }
        public virtual ICollection<DoctorOrders> DoctorOrders { get; set; }
        public virtual ICollection<LabResult> LabResult { get; set; }
        public virtual ICollection<Medications> Medications { get; set; }
        public virtual ICollection<Pdr> Pdr { get; set; }
        public virtual ICollection<Qdform> Qdform { get; set; }
        public virtual ICollection<Qnform> Qnform { get; set; }
        public virtual ICollection<Referral> Referral { get; set; }
    }
}
