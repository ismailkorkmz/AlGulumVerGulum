using DataAccessLayer.Abstract;
using Entity.POCO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer.Validation
{
    public class CategoryValidation : AbstractValidator<Category>
    {
        private readonly ICategoryDal categoryDal;
        public CategoryValidation(ICategoryDal categoryDal)
        {
            RuleFor(x => x.Name).NotNull().WithMessage("İsim Alanı Boş Geçilemez.");
            RuleFor(x => x.Name).Must(CategoryNameValidation).WithMessage("Ad Alanı Mevcut");
            this.categoryDal = categoryDal;
        }
        public bool CategoryNameValidation(string categoryname)
        {
            Category entity = categoryDal.Get().AsQueryable().FirstOrDefault(x => x.Name == categoryname);
            if (entity == null)
                return true;
            return false;

        }
    }
}
