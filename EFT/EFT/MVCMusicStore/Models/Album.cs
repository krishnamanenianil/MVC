using System.Collections.Generic;

namespace MVCMusicStore.Models
{
    public class Album
    {
        public int AlbumId { get; set; }

        public string Title { get; set; }

        //public int NumberOfSongs { get; set; }

        public virtual Artist Artist { get; set; }

        public virtual List<Review> Review { get; set; }
    }
}