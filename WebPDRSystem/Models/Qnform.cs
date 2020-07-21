using System;
using System.Collections.Generic;

namespace WebPDRSystem.Models
{
    public partial class Qnform
    {
        public int Id { get; set; }
        public string PatientCode { get; set; }
        public int SignatureOfQn { get; set; }
        public DateTime DateChecked { get; set; }
        public int Day { get; set; }
        public string Bp { get; set; }
        public string Hr { get; set; }
        public string Rr { get; set; }
        public string O2sat { get; set; }
        public string Temperature { get; set; }
        public string TypeOfFluid { get; set; }
        public string Ivrate { get; set; }
        public DateTime? TimeFluidStarted { get; set; }
        public DateTime? TimeFluidChanged { get; set; }
        public string UrineOutput { get; set; }
        public string Hgt { get; set; }
        public int PdrId { get; set; }
        public string Intake { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Pdr Pdr { get; set; }
        public virtual Pdrusers SignatureOfQnNavigation { get; set; }
    }
}
