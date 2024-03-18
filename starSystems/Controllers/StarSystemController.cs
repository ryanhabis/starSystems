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
        // GET: /starSystem/Welcome/ 
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
