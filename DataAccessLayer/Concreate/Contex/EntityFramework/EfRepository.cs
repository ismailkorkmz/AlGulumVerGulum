using Core.DAL;
using Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concreate.Contex.EntityFramework
{
    public class EfRepository<TEntity, TDbContex>:IRepository<TEntity> where TEntity : class, IBaseEntity, new() where TDbContex : DbContext
    {
        private readonly TDbContex db;
        public EfRepository(TDbContex db)
        {
            this.db = db;
        }
        public bool Add(TEntity entity)
        {
            db.Add(entity);
            return db.SaveChanges() > 0 ? true : false;
        }
        public bool Update(TEntity entity)
        {
            db.Update(entity);
            return db.SaveChanges() > 0 ? true : false;
        }
        public bool Delete(TEntity entity)
        { 
            db.Update(entity);
            return db.SaveChanges() > 0 ? true : false;
        }
        public IEnumerable<TEntity> Get()
        {
            return db.Set<TEntity>();
        }
        public TEntity Get(int id)
        {
            return db.Set<TEntity>().Find(id);
        }
    }
}
