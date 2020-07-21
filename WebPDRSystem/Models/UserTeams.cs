using System;
using System.Collections.Generic;

namespace WebPDRSystem.Models
{
    public partial class UserTeams
    {
        public UserTeams()
        {
            Pdrusers = new HashSet<Pdrusers>();
        }

        public int Id { get; set; }
        public string Team { get; set; }

        public virtual ICollection<Pdrusers> Pdrusers { get; set; }
    }
}
