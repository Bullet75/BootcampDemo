using System;

namespace Silver
{
    class User
    {
        internal string City;
        internal string Car;
        internal int Old;
        internal void GetUserDetails()
        {
            Console.WriteLine("City: {0}", City);
            Console.WriteLine("Car: {0}", Car);
            Console.WriteLine("Old: {0}", Old);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            u.City = "Los Angeles";
            u.City = "Los Angeles";
            u.Car = "Mazda";
            u.Old = 54;
            u.GetUserDetails();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
