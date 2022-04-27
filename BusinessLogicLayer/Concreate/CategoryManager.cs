using BusinessLogicLayer.Abstract;
using Core.Constant;
using DataAccessLayer.Abstract;
using Entity.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer.Concreate
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }

        public EntityResult Add(Category entity)
        {
            try
            {
                //if (entity.Name.Length>50)
                //{
                //    return new EntityResult("Category Name 50'den", EntityResultType.NonValidation);
                //}
                //if (entity.Name==null)
                //{
                //    return new EntityResult("Null", EntityResultType.NonValidation);
                //}
                if (categoryDal.Add(entity))
                {
                    return new EntityResult(ResultTypeMessage.Add());
                }
                return new EntityResult(ResultTypeMessage.Warning(), EntityResultType.Warning);
            }
            catch (Exception ex)
            {

                return new EntityResult(ResultTypeMessage.Error(ex) + ex.ToInnest().Message, EntityResultType.Error);

            }
        }

        public EntityResult Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public EntityResult<IEnumerable<Category>> Get()
        {
            throw new NotImplementedException();
        }

        public EntityResult<Category> Get(int id)
        {
            throw new NotImplementedException();
        }

        public EntityResult<IEnumerable<Category>> GetCategory()
        {
            try
            {
                var result = categoryDal.GetCategory();
                if (result != null && result.Count() > 0)
                {
                    return new EntityResult<IEnumerable<Category>>(result, "Success", EntityResultType.Success);

                }
                return new EntityResult<IEnumerable<Category>>(null, "Notfound", EntityResultType.NotFound);
            }
            catch (Exception ex)
            {

                return new EntityResult<IEnumerable<Category>>(null, "Error: " + ex.ToInnest().Message, EntityResultType.Error);
            }
        }

        public EntityResult Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
