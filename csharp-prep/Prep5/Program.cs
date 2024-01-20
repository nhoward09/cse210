using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeHomePhase();

        string userName = PromptUserName();
        int favoriteNumber = FavNumber();

        int squaredNumber = SqrNumber(favoriteNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void WelcomeHomePhase()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int FavNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SqrNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}