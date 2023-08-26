internal class Program 
{
    private static void Main(string[] args)
    {
        int day;
            Console.Write("Ban thich ngay nao trong tuan : ");
            day = Convert.ToInt32(Console.ReadLine());
        switch (day)
        {
            case 1:System.Console.WriteLine("Toi thich Chu nhat"); break;
            case 2:System.Console.WriteLine("Toi thich Thu 2"); break;
            case 3:System.Console.WriteLine("Toi thich Thu 3"); break;
            case 4:System.Console.WriteLine("Toi thich Thu 4"); break;
            case 5:System.Console.WriteLine("Toi thich Thu 5"); break;
            case 6:System.Console.WriteLine("Toi thich Thu 6"); break;
            case 7:System.Console.WriteLine("Toi thich Thu 7"); break;
            default:
                System.Console.WriteLine("No khong phai ngay trong tuan");
                break;
        }
        
        
    }   
}