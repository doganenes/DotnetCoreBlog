using CoreBlog.API.DataAccessLayer;
using CoreBlog.API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public IActionResult EmployeeList()
        {
            using var c = new Context();
            var values = c.Employees.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult EmployeeAdd(Employee e)
        {
            using var c = new Context();
            c.Add(e);
            c.SaveChanges();
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
            using var c = new Context();
            var employee = c.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(employee);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            using var c = new Context();
            var employee = c.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(employee);
                c.SaveChanges();
                return Ok();
            }
        }

        [HttpPut]
        public IActionResult UpdateEmployee(Employee employee)
        {
            using var c = new Context();
            var emp = c.Find<Employee>(employee.Id);
            if (emp == null)
            {
                return NotFound();
            }
            else
            {
                emp.Name = employee.Name;
                c.Update(emp);
                c.SaveChanges();
                return Ok();
            }

        }
    }
}

// get metodu verileri getirmeye yarar, post metodu yeni veri eklemeye yarar.
// silme için httpdelete, güncelleme için httpput kullan.