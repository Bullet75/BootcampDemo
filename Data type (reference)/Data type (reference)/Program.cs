using System;

namespace DataReference
{
    class Car
    {
        public int age;
    }
    class Program
    {
        static void Vehicles(Car x, Car y)
        {
            x.age = x.age * x.age;
            y.age = y.age * y.age;
            Console.WriteLine(x.age + " " + y.age);
        }
        static void Main(string[] args)
        {
            Car c1 = new Car();
            Car c2 = new Car();
            c1.age = 7;
            c2.age = 27;
            Console.WriteLine(c1.age + " " + c2.age);
            Vehicles(c1, c2);
            Console.WriteLine(c1.age + " " + c2.age);
            Console.WriteLine("Push the button");
            Console.ReadLine();
        }
    }
}