using System;

using System.Text;
namespace PetInfo
{
    class Demo
    {
        private string pet;
        private string petName;
        public string Situated
        {
            get {
                return pet;
            }
            set {
                pet = value;
            }
        }
        public string FireD
        {
            get {
                return petName;
            }
            set {
                petName = value;
            }
        }
    }
    class Program {
        static void Main(string[] args)
        {
            Demo x = new Demo();

            x.FireD = "Flying Dragon";
            x.Situated = "Titan Cage";
            Console.WriteLine("Name: " + x.FireD);
                Console.WriteLine("\nDo not release it!!");
            Console.ReadLine();

        }
    }
}
