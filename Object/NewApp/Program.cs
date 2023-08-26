internal class Program 
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap vao hai so ma ban can so sanh : ");
        int a,b;
        System.Console.Write("a = ");
        a = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("b = ");
        b = Convert.ToInt32(Console.ReadLine());
        if (a == b) {
            System.Console.WriteLine("Hai so bang nhau ");
            }
        if (a > b){
            System.Console.WriteLine("So a lon hon so b");
            }
        if(a < b){        
             System.Console.WriteLine("So a nho hon so b");
             }
        
        
    }


       
}