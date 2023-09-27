namespace NewApp.Models
{
    public class SinhVien : Person
    {
       
        public string Address { get; set; }
        public string  Phone { get; set; }
        public void Nhap()
        {
            
            System.Console.Write("Address = ");
            Address = Console.ReadLine();
            
            System.Console.Write("Phone = ");
            Phone = Console.ReadLine();          
        }
        public void Xuat()
        {
            
            System.Console.WriteLine( FullName + " - " + Address + " - " + Age + " - " + Phone);
        }
    }
}