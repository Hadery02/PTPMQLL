using NewApp.Models;
public class Program{
    public static void Main(string[] args)
    {          
        GiaiPT pt = new GiaiPT();
        int a = 20;
        int b = 40;
        int c = -b/a;
        pt.PTbac1(a,b,c);

        GiaiPT pt1 = new GiaiPT();
        int A = 10;
        int B = -20;
        int C = 5;
        int delta = b*b - 4*a*c;
        pt1.PTbac2(a,b,c,delta);
    }
}