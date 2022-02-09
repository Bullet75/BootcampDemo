
using System;

namespace Silver
{
    class User
    {
        protected string City;
        protected string Car;
        protected int Old;
        protected void GetUserDetails()
        {
            Console.WriteLine("Name: {0}", City);
            Console.WriteLine("Location: {0}", Car);
            Console.WriteLine("Age: {0}", Old);
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
            p.City = "New York";
            p.Car = "Mustang";
            p.Old = 54;
            p.GetUserDetails();
            Console.WriteLine("\nExit..");
            Console.ReadLine();
        }
    }
}