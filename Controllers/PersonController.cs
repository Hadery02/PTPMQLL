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
     public IActionResult Index(string FullName,float HeSoLuong,int PhuCap,int LuongCB)
     {
         float TinhLuong = LuongCB + HeSoLuong + PhuCap ;
        string person = "Luong cua " + FullName + " la :" + TinhLuong;
        ViewBag.Nhap = person;
        return View();
     }
}
