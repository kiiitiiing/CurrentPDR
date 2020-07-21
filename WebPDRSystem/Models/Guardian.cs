using System;
using System.Collections.Generic;

namespace WebPDRSystem.Models
{
    public partial class Guardian
    {
        public Guardian()
        {
            Pdr = new HashSet<Pdr>();
        }

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string ContactNumber { get; set; }
        public int? Barangay { get; set; }
        public int Muncity { get; set; }
        public int Province { get; set; }
        public string Address { get; set; }
        public string Relationship { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Barangay BarangayNavigation { get; set; }
        public virtual Muncity MuncityNavigation { get; set; }
        public virtual Province ProvinceNavigation { get; set; }
        public virtual ICollection<Pdr> Pdr { get; set; }
    }
}
