using Microsoft.AspNetCore.Mvc;

namespace Tanitim.Controllers
{
    public class EnesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
