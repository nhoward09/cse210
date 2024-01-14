using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the number you will be testing? ");
        string userInput = Console.ReadLine();
        int percent = int.Parse(userInput);

        string letter;

        if (percent >= 90)
            letter = "A";

        else if (percent >= 80)
            letter = "B";

        else if (percent >= 70)
            letter = "C";

        else if (percent >= 60)
            letter = "D";

        else
            letter = "F";

        System.Console.WriteLine($"Your grade is a {letter}");

        if (percent < 70)
            System.Console.WriteLine("yOu fAiLeD!");

        else
            System.Console.WriteLine("Congrats you smarty pants! You passed!");



    }
}