using Core.DAL;
using Entity.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal:IRepository<Category>
    {
        IEnumerable<Category> GetCategory();
    }
}
