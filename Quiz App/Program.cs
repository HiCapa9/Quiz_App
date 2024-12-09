namespace Quiz_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[1] 
            { 
                new Question("What is the capital of France? " , 
                new string[] {"Paris", "London", "Berlin", "Madrid" },
                1
                )

            };

            Quiz quiz = new Quiz(questions);
            quiz.DisplayQuestion(questions[0]);

            Console.ReadLine();

        }
    }
}
