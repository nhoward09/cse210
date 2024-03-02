using System;

class Program
{
    static void Main(string[] args)
    {
        int selection;
        Console.Clear();
        Console.WriteLine("Thank you for joining us!\n");

        while (true)
        {
            Console.WriteLine("Please select one of the following:");
            Console.WriteLine("1. Breathing Exercise");
            Console.WriteLine("2. Reflecting Exercise");
            Console.WriteLine("3. Listing Exercise");
            Console.WriteLine("4. Quit");
            selection = int.Parse(Console.ReadLine());


            switch (selection)
            {
                case 1:
                    Breathing choice1 = new Breathing();
                    choice1.StartingMessage();
                    choice1.Breathe();
                    choice1.EndingMessage();
                    break;

                case 2:
                    Reflecting choice2 = new Reflecting();
                    choice2.StartingMessage();
                    choice2.Reflect();
                    choice2.EndingMessage();
                    break;

                case 3:
                    Listing choice3 = new Listing();
                    choice3.StartingMessage();
                    choice3.List();
                    choice3.EndingMessage();
                    break;

                case 4:
                    return;
                default:
                    break;
            }
        }
    }
}