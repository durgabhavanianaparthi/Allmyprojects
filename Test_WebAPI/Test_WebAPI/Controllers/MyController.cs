using Microsoft.AspNetCore.Mvc;

namespace Test_WebAPI.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Index()
        {
            return View();
            Console.WriteLine("hello world");
        }
    }
}

    

