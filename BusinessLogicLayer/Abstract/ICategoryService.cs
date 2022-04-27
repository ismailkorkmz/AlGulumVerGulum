using Core.BLL;
using Core.Constant;
using Entity.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Abstract
{
    public interface ICategoryService:IGenericService<Category>
    {
        EntityResult<IEnumerable<Category>> GetCategory();
    }
}
