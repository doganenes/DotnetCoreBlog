using CoreBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBlog.DataAccessLayer.Abstract
{
    public interface ICategoryDal
    {
        List<Category> ListAllCategories();
        void AddCategory(Category category);
        void DeleteCategory(Category category);
        void UpdateCategory(Category category);
        Category GetCategoryById(int id);
    }
}
