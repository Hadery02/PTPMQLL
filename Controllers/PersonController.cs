using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace DemoMVC.Controllers;

public class PersonController : Controller 
{
    public IActionResult Index()
    {
        return View();
    }
     [HttpPost]
     public IActionResult Index(string FullName,float HeSoLuong,int PhuCap,int Luong)
     {
        string person = "Luong cua " + FullName + " la :";
        float TinhLuong = Luong + HeSoLuong + PhuCap ;
        ViewBag.Nhap = TinhLuong;
        return View();
     }
}
