using Microsoft.AspNetCore.Mvc;

namespace starSystems.Controllers
{
    public class StarSystemController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        // 
        // GET: /starSystem/
        public string Index()
        {
            return "This is my default action...";
        }
        // 
        // GET: /HelloWorld/Welcome/ 
        public IActionResult Welcome(String name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
