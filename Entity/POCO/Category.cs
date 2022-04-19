using Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.POCO
{
    public class Category:BaseEntity
    {
        
        
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public virtual ICollection<ProductCategory> ProductCategory { get; set; }
    }
}
