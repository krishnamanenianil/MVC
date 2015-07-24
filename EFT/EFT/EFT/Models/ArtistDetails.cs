using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFT.Models
{
    public class ArtistDetails
    {
        [Key()]
        [ForeignKey("Artists")]
        public int ArtistId { get; set; }

        public string Bio { get; set; }

        public virtual Artists Artists { get; set; }
    }
}