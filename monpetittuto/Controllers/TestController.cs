using Microsoft.AspNetCore.Mvc;

namespace monpetittuto.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Test1()
        {
            return View();
        }

        public IActionResult Test2()
        {
            return View();
        }
    }
}
