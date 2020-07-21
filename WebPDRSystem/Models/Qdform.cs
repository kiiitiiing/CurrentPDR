using System;
using System.Collections.Generic;

namespace WebPDRSystem.Models
{
    public partial class Qdform
    {
        public int Id { get; set; }
        public string Pdrcode { get; set; }
        public string HealthCareBuddy { get; set; }
        public DateTime DateChecked { get; set; }
        public int Day { get; set; }
        public bool NoSymptoms { get; set; }
        public bool Fever { get; set; }
        public string Temperature { get; set; }
        public bool Cough { get; set; }
        public bool Breathing { get; set; }
        public bool BodyPain { get; set; }
        public bool MuscleJointPain { get; set; }
        public bool Headache { get; set; }
        public bool ChestPain { get; set; }
        public bool Confusion { get; set; }
        public bool BluishLipsFingers { get; set; }
        public bool MedsTaken { get; set; }
        public bool MentalDistress { get; set; }
        public string OtherDetails { get; set; }
        public int SignatureOfQd { get; set; }
        public int PdrId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Pdr Pdr { get; set; }
        public virtual Pdrusers SignatureOfQdNavigation { get; set; }
    }
}
