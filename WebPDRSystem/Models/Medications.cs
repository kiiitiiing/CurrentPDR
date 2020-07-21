using System;
using System.Collections.Generic;

namespace WebPDRSystem.Models
{
    public partial class Medications
    {
        public int Id { get; set; }
        public int Day { get; set; }
        public int PatientId { get; set; }
        public string MedName { get; set; }
        public string Comments { get; set; }
        public int SignatureNurse { get; set; }
        public bool Discontinued { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Patient Patient { get; set; }
        public virtual Pdrusers SignatureNurseNavigation { get; set; }
    }
}
