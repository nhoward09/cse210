using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");


        List<int> myInts = new List<int>();
        int userNumber = -1;

        while (userNumber != 0){
            System.Console.Write("Enter a number (0 to quit): ");

            string addNumber = Console.ReadLine();
            userNumber = int.Parse(addNumber);

            if (userNumber != 0);{
                myInts.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in myInts){
            sum += number;
        }
        
        System.Console.Write($"The sum of the numbers is: {sum}");

        float average = ((float)sum) / myInts.Count;
        System.Console.WriteLine($"The average for the numbers you inputed is: {average}");

        int maxNumber = myInts[0];
        foreach (int number in myInts){
            if (number > maxNumber){
                maxNumber = number;
            }
        }

        System.Console.WriteLine($"the maximum number was {maxNumber}");
    }
}