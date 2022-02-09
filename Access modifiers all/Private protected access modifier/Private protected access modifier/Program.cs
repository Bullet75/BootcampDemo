
using System;

namespace Silver
{
    class User
    {
        private protected string Car;
        private protected string City;
        private protected int Age;
        private protected void GetUserDetails()
        {
            Console.WriteLine("Name: {0}", Car);
            Console.WriteLine("Location: {0}", City);
            Console.WriteLine("Age: {0}", Age);
        }
    }
    class Program : User
    {
        static void Main(string[] args)
        {
            User u = new User();
            Program p = new Program();
            // Complier Error
            // protected members can only accessible with derived classes
            //u.Name = "Suresh Dasari";
            p.Car = "Suresh Dasari";
            p.City = "Hyderabad";
            p.Age = 32;
            p.GetUserDetails();
            Console.WriteLine("\nExit..");
            Console.ReadLine();
        }
    }
}