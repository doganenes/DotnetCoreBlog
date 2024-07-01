using CoreBlog.BusinessLayer.Abstract;
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
        EfCategoryRepository efCategoryRepository;
        public CategoryManager()
        {
            efCategoryRepository = new EfCategoryRepository();
        }
        public void AddCategory(Category category)
        {
            efCategoryRepository.Insert(category);
        }

        public void DeleteCategory(Category category)
        {
            efCategoryRepository.Delete(category);
        }

        public List<Category> GetAllCatgories()
        {
            return efCategoryRepository.GetListAll();
        }

        public Category GetById(int id)
        {   
            return efCategoryRepository.GetById(id);
        }

        public void UpdateCategory(Category category)
        {
            efCategoryRepository.Update(category);
        }
    }
}