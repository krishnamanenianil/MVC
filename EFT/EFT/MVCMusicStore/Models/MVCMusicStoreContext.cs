using System.Data.Entity;

namespace MVCMusicStore.Models
{
    public class MVCMusicStoreContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }

        public DbSet<Review> Reviews { get; set; }
    }
}