using System;

namespace GreenSwitch
{
    public class GenericClass<T>
    {
        public T msg;
        public void genericMethod(T name, T location, T mobile, T car, T gps)
        {
            Console.WriteLine("{0}", msg);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Location: {0}", location);
            Console.WriteLine("Mobile: {0}", mobile);
            Console.WriteLine("Car: {0}", car);
            Console.WriteLine("Gps: {0}", gps);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example Generics");
            
            GenericClass<string> gclass = new GenericClass<string>();
            gclass.msg = "Welcome to GreenSwitch";
            gclass.genericMethod("Silver", "Italy", "(099276888)", "Lexus", ("41.40338, 2.17403"));
            Console.ReadLine();
        }
    }
}