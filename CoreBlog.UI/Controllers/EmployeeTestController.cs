using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CoreBlog.UI.Controllers
{
    public class EmployeeTestController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:7086/api/Default");
            var jsonString = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<Class1>>(jsonString);
            return View(values);
        }
    }

    public class Class1
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
