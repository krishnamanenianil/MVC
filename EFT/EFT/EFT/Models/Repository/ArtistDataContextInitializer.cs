using System.Collections.Generic;
using System.Data.Entity;

namespace EFT.Models.Repository
{
    public class ArtistDataContextInitializer : DropCreateDatabaseAlways<ArtistContext>
    {
        protected override void Seed(ArtistContext context)
        {
            var artist = new Artists() { Name = "anil", Title = "great" };
            context.Artists.Add(artist);

            var album = context.Albums.Add(new Album() { Artist = artist, Title = "First Album" });

            context.ArtistDetails.Add(new ArtistDetails { Artists = artist, Bio = "sdfsadf" });

            context.Reviewer.Add(new Reviewer { Albums = new List<Album> { album }, Name = "test" });

            context.Artists.Add(new SoloArtist { Name = "anil", Title = "great", Instrument = "Voilion" });

            context.SaveChanges();
        }
    }
}