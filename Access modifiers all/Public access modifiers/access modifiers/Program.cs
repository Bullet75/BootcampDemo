using System;

namespace Silver
{
    class User
    {
        public string City;
        public string Car;
        public string Firm;
        public int Age;
        public void GetUserDetails()
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
            u.City = "New York";
            u.Car = "Lexus";
            u.Firm = "Ernst & Young";
            u.Age = 11;
            u.GetUserDetails();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}