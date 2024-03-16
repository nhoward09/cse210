using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Xml.Serialization;


class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new();
        string fileName;
        int score = 0;
        while (true)
        {
            System.Console.Write($"You have {score} points.");

            switch (Menu())
            {
                case 1: //create
                    Console.Clear();
                    System.Console.WriteLine("The types of Goals are:");
                    System.Console.WriteLine("  1. Simple Goal");
                    System.Console.WriteLine("  2. Eternal Goal");
                    System.Console.WriteLine("  3. Checklist Goal");
                    System.Console.Write("Which type of goal would you like to create\n");

                    int createChoice = int.Parse(Console.ReadLine());

                    System.Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    System.Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    System.Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());

                    switch (createChoice)
                    {
                        case 1:
                            goals.Add(new Goal(name, description, points));
                            break;

                        case 2:
                            goals.Add(new Eternal(name, description, points));

                            break;

                        case 3:
                            System.Console.Write("How many times does this goal need to be accompished? ");
                            int count = int.Parse(Console.ReadLine());
                            System.Console.Write("How many bonus points for completing this goal? ");
                            int bonus = int.Parse(Console.ReadLine());
                            goals.Add(new Checklist(name, description, points, count, bonus));
                            break;
                    }
                    Console.Clear();
                    break;

                case 2: //list
                    Console.Clear();
                    System.Console.WriteLine("These are your goals.\n");
                    int listCount = 0;
                    foreach (Goal goal in goals)
                    {
                        listCount++;

                        System.Console.Write($"{listCount}. {goal.Display()}\n");
                    }
                    break;

                case 3: //save
                    System.Console.WriteLine("Please enter the file name");
                    fileName = Console.ReadLine();
                    using (StreamWriter outputFile = new StreamWriter(fileName))
                    {
                        outputFile.WriteLine(score);
                        foreach (var goal in goals)
                        {
                            outputFile.WriteLine(goal.Export());
                        }
                    }
                    Console.Clear();
                    break;

                case 4: //load
                    System.Console.WriteLine("Please enter the file name");
                    fileName = Console.ReadLine();
                    string[] lines = File.ReadAllLines(fileName);
                    score += int.Parse(lines[0]);

                    foreach (string line in lines)
                    {
                        if (line == lines[0])
                        {
                            continue;
                        }
                        string[] parts = line.Split(":");
                        switch (parts[0])
                        {
                            case "":
                                goals.Add(new Goal(parts[1]));
                                break;

                            case "Eternal":
                                goals.Add(new Eternal(parts[1]));
                                break;

                            case "Checklist":
                                goals.Add(new Checklist(parts[1]));
                                break;

                            default: throw new ArgumentException("Invalid File");
                        }

                    }

                    Console.Clear();
                    break;

                case 5:
                    Console.Clear();
                    int listCounter = 0;
                    foreach (Goal goal in goals)
                    {
                        listCounter++;

                        System.Console.Write($"{listCounter}. {goal.DisplayShort()}\n");
                    }
                    System.Console.Write("Which goal did you accomplish? ");
                    int goalChoice = int.Parse(Console.ReadLine());

                    int pointsEarned = goals[goalChoice - 1].RecordEvent();
                    score += pointsEarned;

                    Console.Clear();
                    System.Console.Write($"You earned {pointsEarned} points!");
                    break;

                case 6:
                    return;
            }


        }
    }

    static int Menu()
    {
        System.Console.WriteLine("\n\nMenu Options:");
        System.Console.WriteLine("  1. Create New Goal");
        System.Console.WriteLine("  2. List Goals");
        System.Console.WriteLine("  3. Save Goals");
        System.Console.WriteLine("  4. Load Goals");
        System.Console.WriteLine("  5. Record Goals");
        System.Console.Write("  6. Quit\n");

        int choice = int.Parse(Console.ReadLine());

        return choice;
    }
}