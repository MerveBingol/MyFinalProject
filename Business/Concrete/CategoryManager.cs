using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal; // Bağımlılığımı constructor injection ile yapıyorum

        public CategoryManager(ICategoryDal categoryDal)
            // ben  CategoryManager olarak veri erişim katmanına bağımlıyım ama biraz zayıf bağımlılığım var.
            //çünkü referans(interface) üzerinden bağımlıyım
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<List<Category>> GetAll()
        {
            // iş kodları
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());


        }

        public IDataResult<Category> GetById(int categoryId)
        {
            return  new SuccessDataResult<Category>(_categoryDal.Get(c=>c.CategoryId==categoryId));// küçük olan c aslında vt de ki CategoryId e soruyor
        }
    }
}
