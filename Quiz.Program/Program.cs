// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Dictionary<string, string> questions = new Dictionary<string, string>()

{
    { "What is the capital of France?", "Paris"},
    { "What is the capital of Sweden", "Stockholm"}
};

foreach (var question in questions)
{
    Console.WriteLine(question.Key);
}