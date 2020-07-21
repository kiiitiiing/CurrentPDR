using System;
using System.Collections.Generic;

namespace WebPDRSystem.Models
{
    public partial class Unusualities
    {
        public int Id { get; set; }
        public int PdrId { get; set; }
        public string Issue { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
        public bool? Attended { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Pdr Pdr { get; set; }
    }
}
