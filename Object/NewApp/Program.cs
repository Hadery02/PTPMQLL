internal class Program 
{
    private static void Main(string[] args)
    {
        int a;
        Console.Write("Diem cua hoc sinh la : ");
        a = Convert.ToInt32(Console.ReadLine());
        if(a > 8){
            System.Console.WriteLine("Hoc sinh hoc luc gioi");
        }else if(a >=6.5){
            System.Console.WriteLine("Hoc sinh hoc luc kha");
        }else if(a >=5){
            System.Console.WriteLine("Hoc sinh hoc luc trung binh ");
        }else if(a >=3.5){
            System.Console.WriteLine("Hoc sinh hoc luc yeu");
        }else{
            System.Console.WriteLine("Hoc sinh hoc luc kem");
        }
        
    }


       
}