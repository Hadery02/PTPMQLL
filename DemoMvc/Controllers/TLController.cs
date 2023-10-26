using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace DemoMVC.Controllers;

public class TLController : Controller 
{
    public IActionResult Index()
    {
        return View();
    }
     [HttpPost]
     public IActionResult Index(string FullName,decimal HeSoLuong,int PhuCap,int LuongCB)
     {
        decimal luong = LuongCB * HeSoLuong + PhuCap;
        string tl = FullName + " : " + luong;
        ViewBag.thongbao = tl;
        return View();
     }
}