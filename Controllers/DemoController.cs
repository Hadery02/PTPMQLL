using Microsoft.AspNetCore.Mvc;

namespace   DemoMvc.Controllers
{
    public class DemoController : Controller 
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string Name,string email)
        {
            string strResult = "Hello" + " - " + Name + " - " + email;
            ViewBag.xcv = strResult;
            return View();
        }
    }
}