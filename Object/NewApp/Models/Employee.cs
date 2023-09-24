namespace NewApp.Models
{
    public class Employee
    {
        public string EmployeeID { get; set;}
        public string FullName { get; set;}
        public void NhapThongTin()
        {
            System.Console.Write("PersonID = ");
            EmployeeID =Console.ReadLine();
            System.Console.Write("Full name = ");
             FullName = Console.ReadLine();
        }
        public void HienThi()
        {
            System.Console.WriteLine(EmployeeID + " - " + FullName);
        }
    }
}