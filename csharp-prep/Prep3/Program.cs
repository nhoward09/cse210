using System;

class Program
{
    static void Main(string[] args)
    {
        //     Console.WriteLine("Hello Prep3 World!");


        //     // while loop
        //     int count = 0;
        //     while (count < 5)
        //     {
        //         System.Console.WriteLine($"count = {count}");
        //         count += 1;
        //     }

        // // do-while loop
        // int moreCount = 0;
        // do
        // {
        //     System.Console.WriteLine($"moreCount = {moreCount++}");
        // } while (moreCount < 5);

        //     //for loop
        // for (var i = 0; i < 5; --i)
        // {
        //     System.Console.WriteLine($"i = {i}");
        // }

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11); int guess;
        do
        {

            System.Console.Write("Guess a number: ");
            guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                System.Console.WriteLine($"{guess} was too high!");
            }

            else if (guess < number)
            {
                System.Console.WriteLine($"{guess} was too low!");
            }

            else
            {
                System.Console.WriteLine($"{guess} is correct!");
            }
        } while (number != guess);
    }
}

