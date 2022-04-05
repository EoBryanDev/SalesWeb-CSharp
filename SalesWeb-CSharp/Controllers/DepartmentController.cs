using Microsoft.AspNetCore.Mvc;
using SalesWeb_CSharp.Models;

namespace SalesWeb_CSharp.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department() { Id = 1, Name = "Eletronics" });
            list.Add(new Department() { Id = 2, Name = "Fashion" });

            return View(list);
        }
    }
}
