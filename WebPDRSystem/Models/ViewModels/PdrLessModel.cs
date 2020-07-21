using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPDRSystem.Models.ViewModels
{
    public partial class PdrLessModel
    {
        public int Id { get; set; }
        public string BedNo { get; set; }
        public string CaseNo { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Muncity { get; set; }
        public string Compaints { get; set; }
        public DateTime? AdmissionDate { get; set; }
        public bool Attended { get; set; }
    }
}
