using System;
using System.Collections.Generic;

namespace WebPDRSystem.Models
{
    public partial class ListDocOrders
    {
        public int Id { get; set; }
        public string DoctorsOrder { get; set; }
        public bool Carried { get; set; }
        public bool Administered { get; set; }
        public bool RequestMade { get; set; }
        public bool Endorsed { get; set; }
        public bool Discontinued { get; set; }
        public int DoctorOrderId { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual DoctorOrders DoctorOrder { get; set; }
    }
}
