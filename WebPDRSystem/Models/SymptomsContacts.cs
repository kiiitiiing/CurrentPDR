using System;
using System.Collections.Generic;

namespace WebPDRSystem.Models
{
    public partial class SymptomsContacts
    {
        public SymptomsContacts()
        {
            Pdr = new HashSet<Pdr>();
        }

        public int Id { get; set; }
        public string CloseContacts { get; set; }
        public string SymptomsOfPatient { get; set; }

        public virtual ICollection<Pdr> Pdr { get; set; }
    }
}
