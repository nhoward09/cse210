class Reflecting : Activity
{
    private Random rand = new Random();

    private string RandomPrompt()
    {
        // List of questions
        string[] prompts =
        {
            "-- Think of a time when you stood up for someone else. --",
            "-- Think of a time when you did something really difficult. --",
            "-- Think of a time when you helped someone in need. --",
            "-- Think of a time when you did something truly selfless. --"
        };

        // Pick a random question index
        int randomIndex = rand.Next(prompts.Length);

        // Print the randomly selected question
        return prompts[randomIndex];
    }

    private string RandomQuestion()
    {
        string[] questions = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
            };

        int randomIndex = rand.Next(questions.Length);

        return questions[randomIndex];
    }


    public void Reflect()
    {
        string prompt = RandomPrompt();
        Console.Clear();
        System.Console.WriteLine("Consider the following prompt:");
        System.Console.WriteLine(prompt);
        System.Console.Write("When you have something in mind, press enter to continue.");
        while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;

        System.Console.WriteLine("\nNow consider the following questions as they related to this experience");
        System.Console.Write("You may begin in...");
        Countdown(5);
        Console.Clear();

        System.Console.WriteLine(prompt);

        for (int i = 0; i < Math.Ceiling((float)time / 15); i++)
        {
            System.Console.Write(RandomQuestion());
            Spinner();
            Spinner();
            Spinner();
            System.Console.Write("\n");
        }
    }

    static string discript = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    public Reflecting() : base("Reflecting Activity", discript) { }
}