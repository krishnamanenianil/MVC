using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFT.Models
{
    public class Artists
    {
        public int ArtistsId { get; set; }

        [Required()]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        public string Title { get; set; }

        public virtual List<Album> Albums { get; set; }

        public virtual ArtistDetails ArtistDetails { get; set; }
    }
}