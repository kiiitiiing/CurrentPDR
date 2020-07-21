using System;
using System.Collections.Generic;

namespace WebPDRSystem.Models
{
    public partial class DoctorOrders
    {
        //public DoctorOrders()
        //{
        //    ListDocOrders = new HashSet<ListDocOrders>();
        //}

        public int Id { get; set; }
        public int PdrId { get; set; }
        public DateTime DateOrdered { get; set; }
        public string Comments { get; set; }
        public DateTime? TimePosted { get; set; }
        public int? Signature { get; set; }

        public virtual Pdr Pdr { get; set; }
        public virtual Pdrusers SignatureNavigation { get; set; }
        public virtual List<ListDocOrders> ListDocOrders { get; set; }
    }
}
