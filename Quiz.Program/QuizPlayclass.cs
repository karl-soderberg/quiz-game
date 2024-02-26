public static class QuizPlayclass
{
    public static int Question1()
    {
        Console.WriteLine("How many planets are there in the solarsystem?");
        Console.WriteLine("A:7 \nB:9 \nC:8 \nD:10\n");
        Console.WriteLine("Select option 'A', 'B', 'C' or 'D'\n");
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
        Console.WriteLine("Select option 'A', 'B', 'C' or 'D'\n");
        var input = Console.ReadLine();
        if (input == "a" || input == "A")
        {
            Console.WriteLine("Correct! The answer is A:Venus");
            return 1;
        }
        else
        {
            Console.WriteLine("Wrong! The answer is A:Venus");
            return 0;
        }
    }

    public static int Question3()
    {
        Console.WriteLine("Which planet is known as the Red Planet");
        Console.WriteLine("A:Saturn \nB:Jupiter \nC:Mercury \nD:Mars\n");
        Console.WriteLine("Select option 'A', 'B', 'C' or 'D'\n");
        var input = Console.ReadLine();
        if (input == "d" || input == "D")
        {
            Console.WriteLine("Correct! The answer is D:Mars");
            return 1;
        }
        else
        {
            Console.WriteLine("Wrong! The answer is D:Mars");
            return 0;
        }
    }

    public static int Question4()
    {
        Console.WriteLine("What is the largest planet in our solar system");
        Console.WriteLine("A:Saturn \nB:Jupiter \nC:Mercury \nD:Mars\n");
        Console.WriteLine("Select option 'A', 'B', 'C' or 'D'\n");
        var input = Console.ReadLine();
        if (input == "d" || input == "D")
        {
            Console.WriteLine("Correct! The answer is B:Jupiter");
            return 1;
        }
        else
        {
            Console.WriteLine("Wrong! The answer is B:Jupiter");
            return 0;
        }
    }

    public static int Question5()
    {
        Console.WriteLine("What is the phenomenon where a massive star collapses in on itself, resulting in a supernova?");
        Console.WriteLine("A:Black hole \nB:Red giant \nC:Neutron star \nD:White dwarf\n");
        Console.WriteLine("Select option 'A', 'B', 'C' or 'D'\n");
        var input = Console.ReadLine();
        if (input == "d" || input == "D")
        {
            Console.WriteLine("Correct! The answer is A:Black hole");
            return 1;
        }
        else
        {
            Console.WriteLine("Wrong! The answer is A:Black hole");
            return 0;
        }
    }


}