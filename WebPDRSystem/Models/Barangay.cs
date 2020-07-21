﻿using System;
using System.Collections.Generic;

namespace WebPDRSystem.Models
{
    public partial class Barangay
    {
        public Barangay()
        {
            Guardian = new HashSet<Guardian>();
            Patient = new HashSet<Patient>();
        }

        public int Id { get; set; }
        public int? ProvinceId { get; set; }
        public int MuncityId { get; set; }
        public string Description { get; set; }
        public int OldTarget { get; set; }
        public int Target { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<Guardian> Guardian { get; set; }
        public virtual ICollection<Patient> Patient { get; set; }
    }
}
