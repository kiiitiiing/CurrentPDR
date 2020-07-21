using System;
using System.Collections.Generic;

namespace WebPDRSystem.Models
{
    public partial class Census
    {
        public int Id { get; set; }
        public int Odr { get; set; }
        public int Odg { get; set; }
        public int Qd { get; set; }
        public int Noda { get; set; }
        public int Nodb { get; set; }
        public int? Comorbidities { get; set; }
        public int? MayGoHome { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Pdrusers NodaNavigation { get; set; }
        public virtual Pdrusers NodbNavigation { get; set; }
        public virtual Pdrusers OdgNavigation { get; set; }
        public virtual Pdrusers OdrNavigation { get; set; }
        public virtual Pdrusers QdNavigation { get; set; }
    }
}
