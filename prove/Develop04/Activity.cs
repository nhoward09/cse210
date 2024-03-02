using System;

class Activity
{
    private string name;
    private string discription;
    protected int time;

    public void StartingMessage()
    {
        System.Console.WriteLine($"Welcome to the {name}!");
        System.Console.WriteLine(discription);
        System.Console.WriteLine($"How long would you like to do this activity?");
        time = int.Parse(Console.ReadLine());

        Console.Clear();

        System.Console.Write("Get ready...");
        Spinner();
    }

    public void EndingMessage()
    {
        System.Console.WriteLine("Well done!\n");
        Spinner();
        System.Console.WriteLine($"You have completed {time} seconds of the {name} Activity!");
        Spinner();
        Console.Clear();
    }

    protected void Spinner()
    {
        int spinnerTime = 0;
        while (spinnerTime < 5)
        {
            Console.Write("-");
            System.Threading.Thread.Sleep(200);
            Console.Write('\b' + "\\");
            System.Threading.Thread.Sleep(200);
            Console.Write('\b' + "|");
            System.Threading.Thread.Sleep(200);
            Console.Write('\b' + "/");
            System.Threading.Thread.Sleep(200);
            Console.Write("\b \b");
            spinnerTime += 1;
        }
    }

    protected void Countdown(int n)
    {
        for (int i = 0; i < n; i++)
        {
            System.Console.Write(n - i);
            Thread.Sleep(1000);
            System.Console.Write("\b \b");
        }
    }


    public Activity(string name, string discription)
    {
        this.name = name;
        this.discription = discription;
    }
}
