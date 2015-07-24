using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace ManagingDatabase
{
    public class Album
    {
        public Guid AId { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public AlbumDetail AlbumDetail { get; set; }
    }

    public class MusicContext : DbContext
    {
        public MusicContext()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<MusicContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.HasDefaultSchema("MusicStore");
            //modelBuilder.Entity<Album>().HasKey(t => t.AlbumId);
            //modelBuilder.Entity<Album>().Property(t => t.Title).IsUnicode(false);
            ////modelBuilder.Entity<Album>()
            ////    .Property(t => t.AlbumId)
            ////    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            //modelBuilder.Entity<Album>()
            //   .Property(t => t.AlbumId)
            //   .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Album>().HasKey(t => t.AId);

            modelBuilder.Entity<AlbumDetail>().HasKey(t => t.AlbumId);

            modelBuilder.Entity<Album>()
                .HasOptional(t => t.AlbumDetail)
                .WithRequired(t => t.Album);

            modelBuilder.Entity<Album>()
                .ToTable("Album Info", "dbo");

            modelBuilder.Entity<Album>()
               .Property(t => t.Title)
               .HasColumnName("Album_Title");

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Album> Albums { get; set; }
    }
}