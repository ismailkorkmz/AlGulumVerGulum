using Entity.DTO;
using Entity.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AldimGulumVerdimGulum.Models
{
    public class CategoryDetailsViewModel
    {
        public List<ProductDto> ProductDto { get; set; }
        public List<Category> Category { get; set; }

    }
}
