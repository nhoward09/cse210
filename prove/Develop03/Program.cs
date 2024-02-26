using System;

class Program
{

    static void Main(string[] args)
    {
        var reference = new Reference("Moroni", "10", "5");
        string text = "Behold, I would exhort you that when ye shall read these things, " +
            "if it be wisdom in God that ye should read them, " +
            "that ye would remember how a merciful the Lord hath been unto the children of men, " +
            "from the creation of Adam even down until the time that ye shall receive these things, " +
            "and ponder it in your hearts.";
        var scripture = new Scripture(text, reference);

        reference.Display();

        while (scripture.wordsLeft() != 0)
        {
            Console.Clear();

            scripture.Display();
            scripture.HideWords();
            Console.ReadLine();
        }
    }

}