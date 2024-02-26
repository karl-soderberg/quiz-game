using System;
namespace Quiz.Play;

public class Program
{
    static void Main()
    {

        Dictionary<string, string> questions = new Dictionary<string, string>()
        {
            { "What is the capital of France", "Paris"},
            { "What is the capital of France", "Paris"}
        };

        Console.WriteLine(questions);
    }

}
