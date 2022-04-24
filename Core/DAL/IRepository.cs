using Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DAL
{
    public interface IRepository<TEntity> where TEntity:class,IBaseEntity,new()
    {
        bool Add(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
        IEnumerable<TEntity> Get();
        TEntity Get(int id);
    }
}
