using System;

using System;

namespace Tutlane
{
    abstract class Files
    {
        abstract public void GetData(string x, string y, int z);
    }
    class User : Files
    {
        public override void GetData(string a, string b, int c)
        {
            Console.WriteLine("Name: {0}", a);
            Console.WriteLine("Location: {0}", b);
            Console.WriteLine("Age: {0}", c);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            Console.WriteLine("Abstract Demo");
            u.GetData("Ivan", "Ivano", 66);
            Console.ReadLine();
        }
    }
}
