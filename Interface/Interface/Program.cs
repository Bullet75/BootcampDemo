using System;

// Interface
interface Aliens
{
    void alienLook(); // interface method (does not have a body)
}

// Pig "implements" the IAnimal interface
class Myth : Aliens
{
    public void alienLook()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("Annunaki ancient script says: We will come again");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Myth myMyth = new Myth();  // Create a Pig object
        myMyth.alienLook();
    }
}