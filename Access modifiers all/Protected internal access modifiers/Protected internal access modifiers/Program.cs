using System;

namespace Silver
{
    class User
    {
        protected internal string Car;
        protected internal string City;
        protected internal string Firm;
        protected internal int Age;
        protected internal void GetUserDetails()
        {
            Console.WriteLine("Car: {0}", Car);
            Console.WriteLine("City: {0}", City);
            Console.WriteLine("Firm: {0}", Firm);
            Console.WriteLine("Age: {0}", Age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            u.Car = "Masserati";
            u.Car = "Masserati";
            u.City = "Los Angeles";
            u.Firm = "Heavy & sins";
            u.Age = 32;
            u.GetUserDetails();
            Console.WriteLine("\nExit..");
            Console.ReadLine();
        }
    }
}
