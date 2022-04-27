using DataAccessLayer.Abstract;
using Entity.DTO;
using Entity.POCO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccessLayer.Concreate.Contex.EntityFramework
{
    public class EfProduct : EfRepository<Product, AlGulumVerGulumDbContex>, IProductDal
    {
        AlGulumVerGulumDbContex db = new AlGulumVerGulumDbContex();
        public EfProduct(AlGulumVerGulumDbContex db):base(db)
        {
            this.db = db;
        }
        public IEnumerable<ProductDto> GetProductByCategoryId(int categoryid) 
        {
            var result = from product in db.Product
                         join productCategory in db.ProductCategory
                         on product.Id equals productCategory.ProductId
                         join category in db.Category
                         on productCategory.CategoryId equals category.Id
                         where productCategory.CategoryId == categoryid
                         select new ProductDto
                         {
                             CategoryName = category.Name,
                             Id = product.Id,
                             Name = product.Name,
                             Price = product.Price,
                             Stok = product.Stok,
                             ImageUrl = db.ProductImage.FirstOrDefault(x => x.ProductId == product.Id).Url,
                             CategoryId = category.Id
                         };
            return result;
        
        }

    }
}
