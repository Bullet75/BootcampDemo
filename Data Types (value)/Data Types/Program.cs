using System;

namespace Tutlane
{
    class Program
    {
        static void Triangle(int a, int b, int c)
        {
            a = a * a;
            b = b * b;
            c = c * c;
            Console.WriteLine(a + " " + b + " " + c);
        }
        static void Main(string[] args)
        {
            int num1 = 2;
            int num2 = 17;
            int num3 = 42;
            Console.WriteLine(num1 + " " + num2);
            Triangle(num1, num2, num3);
            Console.WriteLine(num1 + " " + num2 + " " + num3);
            Console.WriteLine("To je to");
            Console.ReadLine();
        }
    }
}