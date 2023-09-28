namespace NewApp.Models
{
    public class Person
    {
        public string PersonID { get; set;}
        public string FullName { get; set;}
        
        public void ps()
        {
            PersonID = "20";
            FullName = "Nguyen van A";
        }
      /*   public void Nhap()
        {
            System.Console.Write("PersonID = ");
            PersonID =Console.ReadLine();
            System.Console.Write("Full name = ");
             FullName = Console.ReadLine();
        }
        public void Xuat()
        {
            System.Console.WriteLine(PersonID + " - " + FullName);
        } */
        
    }
}