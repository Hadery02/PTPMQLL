namespace NewApp.Models
{
    public class Employee
    {
        public string EmployeeID { get; set;}
        public string FullName { get; set;}
        public int Age { get; set; }
        public int Luong { get; set; }
        public void Nhap()
        {
            System.Console.Write("EmployeeID = ");
            EmployeeID = Console.ReadLine();
            System.Console.Write("Full name = ");
             FullName = Console.ReadLine();
            System.Console.Write("Age = ");
            Age = Convert.ToInt32(Console.ReadLine()); 
             System.Console.Write("Luong = ");
            Luong = Convert.ToInt32(Console.ReadLine()) ;          
        }
        public void Xuat()
        {
            
            System.Console.WriteLine(EmployeeID + " - " + FullName + " - " + Age + " - " + Luong);
        }
    }
}