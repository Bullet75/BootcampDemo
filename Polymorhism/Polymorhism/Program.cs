using System;

namespace Skefo
{
    // Base Class
    public class Csharp
    {
        public virtual void GetInfo()
        {
            Console.WriteLine("Learn C# programming language");
        }
    }
    // Derived Class
    public class CBasic : Csharp
    {
        public override void GetInfo()
        {
            Console.WriteLine("This is basic concepts of C#");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CBasic t = new CBasic();
            t.GetInfo();
            Csharp s = new Csharp();
            s.GetInfo();
            Console.WriteLine("\n Focus and learn best languauge for begginers..");
            Console.ReadLine();
        }
    }
}
