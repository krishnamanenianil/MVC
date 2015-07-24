using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFT.Models
{
    public class Album
    {
        public int AlbumId { get; set; }

        [Required()]
        [StringLength(100, MinimumLength = 2)]
        public string Title { get; set; }

        public int ArtistsId { get; set; }

        public virtual Artists Artist { get; set; }

        public virtual List<Reviewer> Reviewers { get; set; }
    }
}