using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Core
{
    public class IEntityRepositoryBase<Tentity, Tcontext> : IEntityRepository<Tentity> where Tentity : class, IEntity, new()
    where Tcontext : DbContext, new()
    {
        public void Add(Tentity entity)
        {
            using (var context = new Tcontext())
            {
                var addedEntry = context.Entry<Tentity>(entity);
                addedEntry.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Delete(Tentity entity)
        {
            using (var context = new Tcontext())
            {
                var deletedEntry = context.Remove<Tentity>(entity);
                deletedEntry.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public Tentity Get(Expression<Func<Tentity, bool>> filter)
        {
            using (var context = new Tcontext())
            {
                return context.Set<Tentity>().SingleOrDefault(filter);
            }
        }
        public List<Tentity> GetAll(Expression<Func<Tentity, bool>> filter = null)
        {
            using (var context = new Tcontext())
            {
                return filter == null ? context.Set<Tentity>().ToList() : context.Set<Tentity>().Where(filter).ToList();
            }
        }
        public void Update(Tentity entity)
        {
            using (var context = new Tcontext())
            {
                var updateEntry = context.Update<Tentity>(entity);
                updateEntry.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }

}
