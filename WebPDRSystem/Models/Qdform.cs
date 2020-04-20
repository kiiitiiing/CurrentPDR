﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPDRSystem.Models
{
    [Table("QDForm")]
    public partial class Qdform
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Pdrcode { get; set; }
        public int HealthCareBuddy { get; set; }
        public bool Fever { get; set; }
        public DateTime DateChecked { get; set; }
        [StringLength(50)]
        public string Temperature { get; set; }
        public bool Cough { get; set; }
        public bool Colds { get; set; }
        public bool Breathing { get; set; }
        public bool BodyMuscleJointPain { get; set; }
        public bool Headache { get; set; }
        public bool ChestPain { get; set; }
        public bool Confusion { get; set; }
        public bool BluishLips { get; set; }
        public bool BluishFingers { get; set; }
        public int? Maintenance { get; set; }
        public bool MedsTaken { get; set; }
        public bool MentalDistress { get; set; }
        public bool SoreThroat { get; set; }
        public bool Diarrhea { get; set; }
        public int? DailyMonitoringForm { get; set; }
        [Column(TypeName = "text")]
        public string OtherDetails { get; set; }
        [Column("SignatureOfQD")]
        public int SignatureOfQd { get; set; }
        public int PdrId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [ForeignKey(nameof(HealthCareBuddy))]
        [InverseProperty(nameof(Pdrusers.QdformHealthCareBuddyNavigation))]
        public virtual Pdrusers HealthCareBuddyNavigation { get; set; }
        [ForeignKey(nameof(PdrId))]
        [InverseProperty("Qdform")]
        public virtual Pdr Pdr { get; set; }
        [ForeignKey(nameof(SignatureOfQd))]
        [InverseProperty(nameof(Pdrusers.QdformSignatureOfQdNavigation))]
        public virtual Pdrusers SignatureOfQdNavigation { get; set; }
    }
}
