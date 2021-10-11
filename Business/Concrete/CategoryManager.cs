using Business.Abstract;
using Core.Aspects.Caching;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        [CacheAspect]
        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }
        [CacheAspect]
        public IDataResult<Category> GetById(int Id)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c=> c.CategoryId==Id));
        }

       
    }
}
