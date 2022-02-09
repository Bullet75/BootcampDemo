using System;

namespace Silver
{
    class User
    {
        private string City;
        private string Car;
        public string Firm;
        private int Age;
        private void GetUserDetails()
        {
            Console.WriteLine("City: {0}", City);
            Console.WriteLine("Car: {0}", Car);
            Console.WriteLine("Firm: {0}", Firm);
            Console.WriteLine("Age: {0}", Age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            // Complier Error
            // These are inaccessible due to private specifier
            u.City = "New York";
            u.Car = "Lexus";
            u.Firm = "Ernst & Young";
            u.Age = 11;
            u.GetUserDetails();
            Console.WriteLine("\nExit..");
            Console.ReadLine();
        }
    }
}
