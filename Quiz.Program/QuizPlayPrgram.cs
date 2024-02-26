// See https://aka.ms/new-console-template for more information

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
// static int Question1()
// {
//     Console.WriteLine("How many planets are there in the solarsystem?");
//     Console.WriteLine("A:7 \nB:9 \nC:8 \nD:10\n");
//     Console.WriteLine("Select option 'A', 'B', 'C' or 'D'");
//     var input = Console.ReadLine();
//     if (input == "c" || input == "C")
//     {
//         Console.WriteLine("Correct! The answer is C:8");
//         return 1;
//     }
//     else 
//     {
//         Console.WriteLine("Wrong! The answer is C:8");
//         return 0;
//     }
// }


int i = 1;
while(i==1)
{
    int score = 0;
    score +=QuizPlayclass.Question1();
    score += QuizPlayclass.Question2();

    Console.WriteLine($"Well Done! Your score is '{score}'");
    i ++;
}

