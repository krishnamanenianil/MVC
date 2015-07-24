using System.Data.Entity;

namespace EFT.Models
{
    public class ArtistContext : DbContext
    {
        public DbSet<Artists> Artists { get; set; }

        public DbSet<Album> Albums { get; set; }

        public DbSet<ArtistDetails> ArtistDetails { get; set; }

        public DbSet<Reviewer> Reviewer { get; set; }
    }
}