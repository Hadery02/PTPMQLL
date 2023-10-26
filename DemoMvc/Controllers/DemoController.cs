using DemoMvc.Controllers;
using Microsoft.AspNetCore.Mvc;
//2021050250-Chu Văn Hiệp

public class Democontroller : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string userId, string password)
    {
        string str = "Hello" + " " + userId + "-" + password;
        ViewBag.thongbao = str;
        return View();
    }

}