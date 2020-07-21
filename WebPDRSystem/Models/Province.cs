using System;
using System.Collections.Generic;

namespace WebPDRSystem.Models
{
    public partial class Province
    {
        public Province()
        {
            Guardian = new HashSet<Guardian>();
            Patient = new HashSet<Patient>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<Guardian> Guardian { get; set; }
        public virtual ICollection<Patient> Patient { get; set; }
    }
}
