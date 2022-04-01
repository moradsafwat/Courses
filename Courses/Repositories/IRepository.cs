using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.Repositories
{
    public interface IRepository<TEntity>
    {
        IList<TEntity> List();
        TEntity Get(int id);
        TEntity Find(int id);
        void AddRange(IEnumerable<TEntity> entities);
        void Add(TEntity entity);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
        void Update(int id, TEntity entity);
        void SaveAsync();




    }
}
