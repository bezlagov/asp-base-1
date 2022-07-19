using Microsoft.AspNetCore.Mvc;

namespace FirstTest.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Message");
        }

        public IActionResult Message()
        {
            return View();
        }
    }
}
