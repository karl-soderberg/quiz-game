public static class QuizPlayclass
{
    public static int Question1()
    {
        Console.WriteLine("How many planets are there in the solarsystem?");
        Console.WriteLine("A:7 \nB:9 \nC:8 \nD:10\n");
        Console.WriteLine("Select option 'A', 'B', 'C' or 'D'");
        var input = Console.ReadLine();
        if (input == "c" || input == "C")
        {
            Console.WriteLine("Correct! The answer is C:8");
            return 1;
        }
        else 
        {
            Console.WriteLine("Wrong! The answer is C:8");
            return 0;
        }
    }
    public static int Question2()
    {
        Console.WriteLine("Which planet is closes to the sun?");
        Console.WriteLine("A:Venus \nB:Earth \nC:Mercury \nD:Mars\n");
        Console.WriteLine("Select option 'A', 'B', 'C' or 'D'");
        var input2 = Console.ReadLine();
        if (input2 == "a" || input2 == "A")
        {
            Console.WriteLine("Correct! The answer is A:Venus");
            return 1;
        }
        else
        {
            Console.WriteLine("Wrong! The answer is C:8");
            return 0;
        }
    }


}