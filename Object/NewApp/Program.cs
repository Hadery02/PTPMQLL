using NewApp.Models;
public class Program{
    public static void Main(string[] args)
    {          
        SinhVien sv1 = new SinhVien();
        System.Console.WriteLine("Du lieu vua nhap la : ");
        sv1.Nhap();
        sv1.Xuat();
    }
}