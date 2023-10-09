namespace NewApp.Models
{
    public class SinhVien
    {
       public string PersonID { get; set;}
        public string FullName { get; set;}
         public int Age { get; set; }
        public string Address { get; set; }
        public string  Phone { get; set; }
        public void Nhap()
        {
            try{
            System.Console.Write("PersonID = ");
            PersonID =Console.ReadLine();
            System.Console.Write("Full name = ");
             FullName = Console.ReadLine();
            System.Console.Write("Address = ");
             System.Console.Write("Age = ");
            Age = Convert.ToInt32(Console.ReadLine()) ;   
            Address = Console.ReadLine();
            
            System.Console.Write("Phone = ");
            Phone = Console.ReadLine();          
        }
        catch {
                System.Console.WriteLine("du lieu ban da nhap sai:");
        }}
        public void Xuat()
        {
            
            System.Console.WriteLine( FullName + " - " + Address + " - " + Age + " - " + Phone);
        }
    }
}