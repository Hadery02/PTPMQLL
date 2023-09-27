namespace NewApp.Models
{
    public class SinhVien 
    {
        public string FullName { get; set;}
        public string Address { get; set; }
        public int Age { get; set; }
        public string  Phone { get; set; }
        public void Nhap()
        {
            System.Console.Write("Full name = ");
            FullName = Console.ReadLine();
            System.Console.Write("Address = ");
            Address = Console.ReadLine();
            System.Console.Write("Age = ");
            Age = Convert.ToInt32(Console.ReadLine()); 
            System.Console.Write("Phone = ");
            Phone = Console.ReadLine();          
        }
        public void Xuat()
        {
            
            System.Console.WriteLine( FullName + " - " + Address + " - " + Age + " - " + Phone);
        }
    }
}