using DataAccessLayer.Abstract;
using Entity.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concreate.Contex.EntityFramework
{
    public class EfProduct : EfRepository<Product, AlGulumVerGulumDbContex>, IProductDal
    {
        public EfProduct(AlGulumVerGulumDbContex db):base(db)
        {

        }
    }
}
