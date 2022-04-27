using Core.DAL;
using Entity.DTO;
using Entity.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IProductDal : IRepository<Product>
    {
        IEnumerable<ProductDto> GetProductByCategoryId(int categoryid);
    }
}
