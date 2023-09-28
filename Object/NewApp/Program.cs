using NewApp.Models;
public class Program{
    public static void Main(string[] args)
    {     
        Person[] ps = new Person[3];
    for(int i = 0; i < ps.Length; i++)
    {
        Person std = new Person ();
        System.Console.Write("Nhap phan tu thu {0}: ", i);
        int a = Convert.ToInt32(Console.ReadLine());
        ps[i] = std;
        System.Console.WriteLine();
    }












       /*  Employee emp = new Employee();
        System.Console.WriteLine("hay nhap du lieu : ");
        emp.Nhap();
        emp.Xuat(); */








       /*  GiaiPT pt = new GiaiPT();
        int a = 20;
        int b = 40;
        int c = -b/a;
        pt.PTbac1(a,b,c);

        GiaiPT pt1 = new GiaiPT();
        int A = 10;
        int B = -20;
        int C = 5;
        int delta = b*b - 4*a*c;
        pt1.PTbac2(a,b,c,delta); */
     
    }

}