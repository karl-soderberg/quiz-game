// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;



// Dictionary<string, Dictionary<string, bool>> questions = new Dictionary<string, Dictionary<string, bool>>()
// {
//     {   
//         "What is the capital of France?", 
//         new Dictionary<string, bool>()
//         {
//             {"A: Marseille", false},
//             {"B: London", false},
//             {"C: Stockholm", false},
//             {"C: Paris", true},
//         }
//     },
//     {   "How many planets are there in the solarsystem", 
//         new Dictionary<string, bool>()
//         {
//             {"A: 9", false},
//             {"B: 8", true},
//             {"C: 10", false},
//             {"C: 7", false},
//         }
//     },
// };

int i = 1;
while(i==1)
{
    int score = 0;
    Console.WriteLine("How many planets are there in the solarsystem?");
    Console.WriteLine("A:7 \nB:9 \nC:8 \nD:10\n");
    Console.WriteLine("Select option 'A', 'B', 'C' or 'D'");
    var input = Console.ReadLine();
    if (input == "c" || input == "C")
    {
        Console.WriteLine("Correct! The answer is C:8");
        score ++;
    }
    if (input == "a" || input == "A" ||
        input == "b" || input == "B" || 
        input == "d" || input == "D")
    {
        Console.WriteLine("Wrong! The answer is C:8");
    }
    else
        {
            Console.WriteLine("Invalid input");
        }

    Console.WriteLine("Which planet is closes to the sun?");
    Console.WriteLine("A:Venus \nB:Earth \nC:Mercury \nD:Mars\n");
    Console.WriteLine("Select option 'A', 'B', 'C' or 'D'");
    var input2 = Console.ReadLine();
    if (input2 == "a" || input2 == "A")
    {
        Console.WriteLine("Correct! The answer is A:Venus");
        score ++;
    }
    if (input2 == "b" || input2 == "B" ||
        input2 == "c" || input2 == "C" ||
        input2 == "d" || input2 == "D")
    {
        Console.WriteLine("Wrong! The answer is C:8");
    }
    else
        {
            Console.WriteLine("Invalid input");
        }

    
    i++;
}