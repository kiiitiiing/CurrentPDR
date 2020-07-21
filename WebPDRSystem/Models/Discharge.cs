using System;
using System.Collections.Generic;

namespace WebPDRSystem.Models
{
    public partial class Discharge
    {
        public int Id { get; set; }
        public int Pdrid { get; set; }
        public DateTime DateDischarged { get; set; }
        public int HealthCareBuddy { get; set; }
        public int DischargedBy { get; set; }
        public string DischargedApprovedBy { get; set; }
        public string QuarantineDirectorOrOfficer { get; set; }
        public string GuardOnDuty { get; set; }

        public virtual Pdrusers DischargedByNavigation { get; set; }
        public virtual Pdrusers HealthCareBuddyNavigation { get; set; }
        public virtual Pdr Pdr { get; set; }
    }
}
