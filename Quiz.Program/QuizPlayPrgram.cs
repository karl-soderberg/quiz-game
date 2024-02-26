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

int i = 1;
while(i==1)
{
    int score = 0;
    Console.WriteLine("\nWelcome to this stellar quiz! Lets quiz it up \n");
    int milliseconds = 1500;
    Thread.Sleep(milliseconds);
    score +=QuizPlayclass.Question1();
    Thread.Sleep(milliseconds);
    score += QuizPlayclass.Question2();
    Thread.Sleep(milliseconds);
    score += QuizPlayclass.Question3();
    Thread.Sleep(milliseconds);
    score += QuizPlayclass.Question4();
    Thread.Sleep(milliseconds);
    score += QuizPlayclass.Question5();

    Console.WriteLine($"Well Done! Your score is '{score}'");
    i ++;
}

