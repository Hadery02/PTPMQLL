internal class Program 
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap vao hai so ma ban can tinh : ");
        int a,b;
        System.Console.Write("a = ");
        a = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("b = ");
        b = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Hieu cua 2 so la : {0} - {1} = {2} ",a,b,a-b);
        System.Console.WriteLine("Tich cua 2 so la : {0} * {1} = {2} ",a,b,a*b);
        System.Console.WriteLine("Thuong cua 2 so la : {0} / {1} = {2} ",a,b,a/b);
        System.Console.WriteLine("So du cua 2 so la : {0} % {1} = {2} ",a,b, (a - b * (a / b)));
    }


       
}