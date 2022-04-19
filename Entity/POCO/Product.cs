using Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.POCO
{
    public class Product:BaseEntity
    {
        
        
        public int Stok { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ProductImage> ProductImage { get; set; }
        public virtual ICollection<ProductCategory> ProductCategory { get; set; }

    }
}
