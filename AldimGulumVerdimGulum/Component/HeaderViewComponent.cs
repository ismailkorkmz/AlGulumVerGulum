using AldimGulumVerdimGulum.Models;
using BusinessLogicLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AldimGulumVerdimGulum.Component
{
    public class HeaderViewComponent:ViewComponent
    {
        ///Views/Shared/Components/Header/Default.cshtml
        private readonly ICategoryService categoryService;
        public HeaderViewComponent(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        public IViewComponentResult Invoke()
        {
            HeaderViewModel model = new HeaderViewModel();
            var categories = categoryService.GetCategory();
            switch (categories.ResultType)
            {
                case Core.Constant.EntityResultType.Success:
                    model.Category = categories.Data.ToList();
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
            return View(model);
        }
    }
}
