using Microsoft.AspNetCore.Mvc;

namespace SalesWeb_CSharp.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
