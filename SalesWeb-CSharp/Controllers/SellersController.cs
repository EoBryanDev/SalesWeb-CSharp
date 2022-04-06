using Microsoft.AspNetCore.Mvc;

namespace SalesWeb_CSharp.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
