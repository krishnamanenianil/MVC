using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EFT.Models.Repository
{
    public class Repository<T> where T : class
    {
        public ArtistContext DbContext = new ArtistContext();

        protected DbSet<T> Dbset { get; set; }

        public Repository()
        {
            Dbset = DbContext.Set<T>();
        }

        public List<T> GetAll()
        {
            return Dbset.ToList();
        }

        public void Add(T entity)
        {
            Dbset.Add(entity);
        }

        public T Find(int id)
        {
            return Dbset.Find(id);
        }

        public void Update(T entity)
        {
            DbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Dbset.Remove(Dbset.Find(id));
        }

        public void SaveChanges()
        {
            DbContext.SaveChanges();
        }

        public void Remove(T entity)
        {
            Dbset.Remove(entity);
        }

        public void Dispose()
        {
            DbContext.Dispose();
        }
    }
}