using CoreBlog.BusinessLayer.Abstract;
using CoreBlog.DataAccessLayer.Repositories;
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
        GenericRepository<Category> repo = new GenericRepository<Category>();
        CategoryRepository categoryRepository = new CategoryRepository();
        public void AddCategory(Category category)
        {
            if (category.CategoryName != "" && category.CategoryDescription != "" && category.CategoryName.Length >= 5 && category.CategoryStatus == true)
            {
                categoryRepository.AddCategory(category);
            }
            else
            {

            }
        }

        public void DeleteCategory(Category category)
        {
            if(category.CategoryId != 0)
            {
                repo.Delete(category);
            }
        }

        public List<Category> GetAllCatgories()
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
