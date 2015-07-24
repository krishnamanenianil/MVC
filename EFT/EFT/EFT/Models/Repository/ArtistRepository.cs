using System;
using System.Collections.Generic;
using System.Linq;

namespace EFT.Models.Repository
{
    public class ArtistRepository : Repository<Artists>, IArtistRepository
    {
        public List<Artists> GetByName(String name)
        {
            return Dbset.Where(a => a.Name == name).ToList();
        }

        public List<SoloArtist> GetSoloArtist()
        {
            return Dbset.OfType<SoloArtist>().ToList();
        }
    }

    public interface IArtistRepository
    {
        List<Artists> GetByName(String name);
    }
}