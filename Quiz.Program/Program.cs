// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Dictionary<string, Dictionary<string, bool>> questions = new Dictionary<string, Dictionary<string, bool>>()

{
    {   
        "What is the capital of France?", 
        new Dictionary<string, bool>()
        {
            {"A: Marseille", false},
            {"B: London", false},
            {"C: Stockholm", false},
            {"C: Paris", true},
        }
    },
    {   "What is the capital of France?", 
        new Dictionary<string, bool>()
        {
            {"A: 9", false},
            {"B: 8", true},
            {"C: 10", false},
            {"C: 7", false},
        }
    },
};


foreach (var question in questions)
{
    Console.WriteLine(question.Key);
    Console.WriteLine("Select your option");
}