using CoreBlog.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreBlog.API.DataAccessLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ENES\\SQLEXPRESS;database=CoreBlogApiDB;TrustServerCertificate=true;Trusted_Connection=true");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
