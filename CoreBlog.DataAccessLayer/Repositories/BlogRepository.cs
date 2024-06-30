using CoreBlog.DataAccessLayer.Abstract;
using CoreBlog.DataAccessLayer.Concrete;
using CoreBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBlog.DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        Context c = new Context();
        public void AddBlog(Blog blog)
        {
            c.Add(blog);
            c.SaveChanges();
        }

        public void DeleteBlog(Blog blog)
        {
            c.Remove(blog);
            c.SaveChanges();

        }

        public Blog GetBlogById(int id)
        {
            return c.Blogs.Find(id);
        }

        public List<Blog> ListAllBlogs()
        {
            return c.Blogs.ToList();
        }

        public void UpdateBlog(Blog blog)
        {
            c.Update(blog);
            c.SaveChanges();
        }
    }
}
