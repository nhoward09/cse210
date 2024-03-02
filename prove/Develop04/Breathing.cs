class Breathing : Activity
{

    public void Breathe()
    {
        int duration = 1;

        while (time >= duration)
        {
            Console.Write("\n\nBreathe in... ");
            Countdown(4);


            Console.Write("\nBreathe out... ");
            Countdown(6);


            duration += 10;
        }
    }

    static string desc = "This activity will help you to relax by walking you thorugh breathing in and out slowly. Clear your mind and focus on your breathing";
    public Breathing() : base("Breathing Activity", desc) { }
}