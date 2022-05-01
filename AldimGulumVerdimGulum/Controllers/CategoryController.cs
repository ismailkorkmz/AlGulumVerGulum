using AldimGulumVerdimGulum.Models;
using BusinessLogicLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AldimGulumVerdimGulum.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;
        public CategoryController(IProductService productService, ICategoryService categoryService)
        {
            this.productService = productService;
            this.categoryService = categoryService;
        }
        public IActionResult Index(int id)
        {
            CategoryDetailsViewModel model = new CategoryDetailsViewModel();
            model.Category = categoryService.GetCategory().Data.ToList();
            var result = productService.GetProductByCategoryId(id);
            switch (result.ResultType)
            {
                case Core.Constant.EntityResultType.Success:
                    model.ProductDto = result.Data.ToList();
                    return View(model);
                case Core.Constant.EntityResultType.Error:
                    break;
                case Core.Constant.EntityResultType.Warning:
                    break;
                case Core.Constant.EntityResultType.NonValidation:
                    break;
                case Core.Constant.EntityResultType.NotFound:
                    break;
                default:
                    break;
            }
            return View();
        }
    }
}
