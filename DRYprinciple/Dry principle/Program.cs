
public void Sentence1()
{
    var message = "What a beautifull day.";
    message = "Heya all " + message;
    Console.WriteLine(message);
}
public void Sentence2()
{
    var message = "We are running today.";
    message = "Heya all " + message;
    Console.WriteLine(message);
}
public void Sentence3()
{
    var message = "Example of DRY principle.";
    message = "Heya, all " + message;
    Console.WriteLine(message);
}


// OTHER SAMPLE OF DRY PRINCIPLE

public void Sentence1()
{
    PrintJob("What a beautifull day.");
}
public void Sentence2()
{
    PrintJob("We are running today");
}
public void Sentence3()
{
    PrintJob("Example of DRY principle.");
}
public void PrintJob(string message)
{
    Console.WriteLine($"Heya all {message}");
}