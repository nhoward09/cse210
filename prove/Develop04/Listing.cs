using System.Security.Cryptography;

class Listing : Activity
{
    public void List()
    {
        System.Console.WriteLine("List as many responses you can to the following prompt:");

        System.Console.WriteLine(RandomPrompt());
        Countdown(5);

        DateTime endTime = DateTime.Now.AddSeconds(time);
        int count = 0;
        while (DateTime.Now < endTime)
        {
            System.Console.Write("> ");
            Console.ReadLine();
            count++;
        }
        System.Console.WriteLine($"You listed {count} things!");
    }

    private Random rand = new Random();

    private string RandomPrompt()
    {
        // List of questions
        string[] prompts =
        {
            "--- Who are people that you appreciate? ---",
            "--- What are personal strengths of yours? ---",
            "--- Who are people that you have helped this week? ---",
            "--- When have you felt the Holy Ghost this month? ---",
            "--- Who are some of your personal heroes? ---"
        };

        // Pick a random question index
        int randomIndex = rand.Next(prompts.Length);

        // Print the randomly selected question
        return prompts[randomIndex];
    }


    static string descript = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    public Listing() : base("Listing Activity", descript)
    {

    }
}