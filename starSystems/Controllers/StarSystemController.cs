using Microsoft.AspNetCore.Mvc;

namespace starSystems.Controllers
{
    public class StarSystemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
