using System;
using System.Collections.Generic;

namespace WebPDRSystem.Models
{
    public partial class LabResult
    {
        public int Id { get; set; }
        public int PdrId { get; set; }
        public int AttendingPhysician { get; set; }
        public string ResultPic { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Pdrusers AttendingPhysicianNavigation { get; set; }
        public virtual Pdr Pdr { get; set; }
    }
}
