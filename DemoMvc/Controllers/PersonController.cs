using DemoMvc.Controllers;
using Microsoft.AspNetCore.Mvc;
//2021050250-Chu Văn Hiệp

public class PersonController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(Person ps)
    {
        string str = "Hello" + " " + ps.PersonId + "-" + ps.FullName;
        ViewBag.thongbao = str;
        return View();
    }

}