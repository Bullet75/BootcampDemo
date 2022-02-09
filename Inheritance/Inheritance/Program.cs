using System;

namespace Inheritance
{

    // base class
    class Human
    {

        public string job;

        public void display()
        {
            Console.WriteLine("I am a man");
        }

    }

    // derived class of Animal 
    class Being : Human
    {

        public void getJob()
        {
            Console.WriteLine("I work as " + job);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {

            // object of derived class
            Being Marko = new Being();

            // access field and method of base class
            Marko.job = "Electrician";
            Marko.display();

            // access method from own class
            Marko.getJob();

            Console.ReadLine();
        }

    }
}