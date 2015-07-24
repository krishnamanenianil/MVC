using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFT.Models
{
    public class Reviewer
    {
        public int ReviewerId { get; set; }

        public string Name { get; set; }

        public virtual List<Album> Albums { get; set; }
    }
}