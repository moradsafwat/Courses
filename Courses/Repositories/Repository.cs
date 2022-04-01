using Courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly CourseDbContext db;
        public Repository(CourseDbContext _db)
        {
            db = _db;
        }
        public void Add(TEntity entity)
        {
            db.Set<TEntity>().Add(entity);
            SaveAsync();
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            db.Set<TEntity>().AddRange(entities);
            SaveAsync();
        }

        public TEntity Find(int id)
        {
            var entity = db.Set<TEntity>().Find(id);
            return entity; ;
        }

        public TEntity Get(int id)
        {
            return db.Set<TEntity>().Find(id);
        }

        public IList<TEntity> List()
        {
            return db.Set<TEntity>().ToList();
        }

        public void Remove(TEntity entity)
        {
            db.Set<TEntity>().Remove(entity);
            SaveAsync();
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            db.Set<TEntity>().RemoveRange(entities);
        }

        public void SaveAsync()
        {
            db.SaveChanges();
        }

        public void Update(int id, TEntity entity)
        {
            db.Set<TEntity>().Update(entity);
            SaveAsync();
        }
    }
}
