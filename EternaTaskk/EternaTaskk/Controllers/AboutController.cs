using Microsoft.AspNetCore.Mvc;

namespace EternaTaskk.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
