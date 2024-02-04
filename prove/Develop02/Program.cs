using System;

class Program
{
    static public Journal journal;

    static void Main(string[] args)
    {
        journal = new Journal();

        bool keepGoing = true;
        string fileName;

        while (keepGoing)
        {
            switch (Menu.menuOptions())
            {

                case 1:
                    //Prompt user with a random prompt
                    List<string> prompts = new List<string> { "Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?" };
                    //Read in user input

                    Random randomGenerator = new Random();
                    string prompt = prompts[randomGenerator.Next(0, prompts.Count)];

                    System.Console.WriteLine(prompt);
                    string response = Console.ReadLine();

                    var entry = new Entry(response, prompt);
                    journal.AddEntry(entry);
                    break;

                case 2:
                    journal.Display();
                    break;

                case 3:
                    System.Console.WriteLine("Please enter the file name");
                    fileName = Console.ReadLine();
                    journal.Save(fileName);
                    break;

                case 4:
                    System.Console.WriteLine("Please enter the file name");
                    fileName = Console.ReadLine();
                    journal.Load(fileName);

                    break;

                case 5:
                    keepGoing = false;
                    break;
            }
        }
    }
}