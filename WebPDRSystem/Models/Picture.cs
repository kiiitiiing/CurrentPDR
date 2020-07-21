using System;
using System.Collections.Generic;

namespace WebPDRSystem.Models
{
    public partial class Picture
    {
        public int Id { get; set; }
        public string PhotoString { get; set; }
        public string PhotoFilePath { get; set; }
    }
}
