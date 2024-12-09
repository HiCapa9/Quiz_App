namespace Quiz_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[3] 
            { 
                new Question("What is the capital of France? " , 
                new string[] {"Paris", "London", "Berlin", "Madrid" },
                0
                ),
                new Question("What is the capital of GErmany? " ,
                new string[] {"Paris", "London", "Berlin", "Madrid" },
                2
                ),
                new Question("What is 2 + 2 " ,
                new string[] {"3", "4", "5", "6" },
                1
                )

            };

            Quiz quiz = new Quiz(questions);
            quiz.StartQuiz();
            Console.ReadLine();

        }
    }
}
