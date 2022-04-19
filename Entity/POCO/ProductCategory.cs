using Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.POCO
{
    public class ProductCategory:BaseEntity
    {
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public virtual Category Category { get; set; }
    }
}
