using BusinessLogicLayer.Abstract;
using Core.Constant;
using DataAccessLayer.Abstract;
using Entity.DTO;
using Entity.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer.Concreate
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal productDal;
        public ProductManager(IProductDal productDal)
        {
            this.productDal = productDal;
        }
        public EntityResult Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public EntityResult Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public EntityResult<IEnumerable<Product>> Get()
        {
            throw new NotImplementedException();
        }

        public EntityResult<Product> Get(int id)
        {
            throw new NotImplementedException();
        }

        public EntityResult Update(Product entity)
        {
            throw new NotImplementedException();
        }

        EntityResult<IEnumerable<ProductDto>> IProductService.GetProductByCategoryId(int categoryid)
        {
            try
            {
                var result = productDal.GetProductByCategoryId(categoryid);
                if (result != null && result.Count() > 0)
                {
                    return new EntityResult<IEnumerable<ProductDto>>(result, "Success");
                }
                return new EntityResult<IEnumerable<ProductDto>>(null, "NotFound", EntityResultType.NotFound);
            }
            catch (Exception ex)
            {

                return new EntityResult<IEnumerable<ProductDto>>(null, ex.ToInnest().Message, EntityResultType.Error);
            }
        }
    }
}
