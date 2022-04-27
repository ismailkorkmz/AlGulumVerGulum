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
        public CategoryController(IProductService productService)
        {
            this.productService = productService;
        }
        public IActionResult Index(int id)
        {
            var result = productService.GetProductByCategoryId(id);
            switch (result.ResultType)
            {
                case Core.Constant.EntityResultType.Success:
                    return View(result.Data.ToList());
                    break;
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
