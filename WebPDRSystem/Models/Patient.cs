using System;
using System.Collections.Generic;

namespace WebPDRSystem.Models
{
    public partial class Patient
    {
        public Patient()
        {
            Medications = new HashSet<Medications>();
            Pdr = new HashSet<Pdr>();
        }

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        public string BloodType { get; set; }
        public string ContactNumber { get; set; }
        public int? Barangay { get; set; }
        public int Muncity { get; set; }
        public int Province { get; set; }
        public string Address { get; set; }
        public string Occupation { get; set; }
        public string CivilStatus { get; set; }
        public string Nationality { get; set; }
        public string Religion { get; set; }
        public string Picture { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Barangay BarangayNavigation { get; set; }
        public virtual Muncity MuncityNavigation { get; set; }
        public virtual Province ProvinceNavigation { get; set; }
        public virtual ICollection<Medications> Medications { get; set; }
        public virtual ICollection<Pdr> Pdr { get; set; }
    }
}
