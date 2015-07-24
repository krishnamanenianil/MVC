using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCMusicStore.Models
{
    public class Review
    {
        public int ReviewId { get; set; }

        [Required]
        public int AlbumId { get; set; }

        public string Contenets { get; set; }

        [EmailAddress]
        [Required]
        [DisplayName("EmailAddress")]
        public string ReviewerEmail { get; set; }

        public virtual Album Album { get; set; }
    }
}