using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Quiz.Test;

public class UnitTest1
{
    [Fact]
    public void Question1_should_return1_if_correct()
    {
        string rightanswer = "A";

        int result = QuizPlayclass.Question1();
        


    }
}