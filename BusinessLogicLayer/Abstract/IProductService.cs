using Core.BLL;
using Core.Constant;
using Entity.DTO;
using Entity.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Abstract
{
    public interface IProductService:IGenericService<Product>
    {
        EntityResult<IEnumerable<ProductDto>> GetProductByCategoryId(int categoryid);
    }
}
