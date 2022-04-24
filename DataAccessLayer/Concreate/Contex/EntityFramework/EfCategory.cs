using Entity.POCO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Abstract;

namespace DataAccessLayer.Concreate.Contex.EntityFramework
{
    public class EfCategory:EfRepository<Category,AlGulumVerGulumDbContex>,ICategoryDal
    {
        private readonly AlGulumVerGulumDbContex db;
        public EfCategory(AlGulumVerGulumDbContex db):base(db)
        {
            this.db = db;
        }
         public IEnumerable<Category> GetCategory() 
        {
            return db.Category
                .Include(x => x.ProductCategory)
                .ThenInclude(x => x.Product)
                .Where(x => x.Active && !x.Delete);
        }
    }
}
