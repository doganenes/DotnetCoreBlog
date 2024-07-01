using CoreBlog.BusinessLayer.Abstract;
using CoreBlog.DataAccessLayer.Abstract;
using CoreBlog.DataAccessLayer.EntityFramework;
using CoreBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBlog.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void AddCategory(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void DeleteCategory(Category category)
        {
            _categoryDal.Delete(category);
        }

        public List<Category> GetAllCatgories()
        {
            return _categoryDal.GetListAll();
        }

        public Category GetById(int id)
        {   
            return _categoryDal.GetById(id);
        }

        public void UpdateCategory(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}