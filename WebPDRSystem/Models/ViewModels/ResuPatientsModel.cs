using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPDRSystem.Models.ViewModels
{
    public partial class ResuPatientsModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public DateTime DoB { get; set; }
        public string Address { get; set; }
        public string PatientContactNo { get; set; }
        public string Guardian { get; set; }
        public string GuardianContactNo { get; set; }
        public DateTime? DateAdmitted { get; set; }
    }
}
