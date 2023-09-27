namespace NewApp.Models
{
    public class PTBAC1
    { 
        public string a { get; set;}
        public string b { get; set;}
        public void NhapThongTin()
        {
            System.Console.Write("PersonID = ");
            a =Console.ReadLine();
            System.Console.Write("Full name = ");
            b = Console.ReadLine();
           
        }
        public void HienThi()
        {
            System.Console.WriteLine("{0}x + {1} = 0 \n=> x = {2}", a, b);
        }
    }
}