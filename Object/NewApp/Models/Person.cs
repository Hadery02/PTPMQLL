namespace NewApp.Models
{
    public class Person
    {
        public string PersonID { get; set;}
        public string FullName { get; set;}
        public void NhapThongTin()
        {
            System.Console.Write("PersonID = ");
            PersonID =Console.ReadLine();
            System.Console.Write("Full name = ");
             FullName = Console.ReadLine();
        }
        public void HienThi()
        {
            System.Console.WriteLine(PersonID + " - " + FullName);
        }
    }
}