namespace ManagingDatabase
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var context = new MusicContext())
            {
                var album = new Album { Price = 12m, Title = "drushyam" };
                context.Albums.Add(album);
                context.SaveChanges();
            }
        }
    }
}