using System;

class Program
{
    static void Main(string[] args)
    {
        // to use print, address the console, then writeline()

        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();



        System.Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}





// //primitive types

// int i;
// long l;
// float f;
// double d;
// char c;
// string s;
// byte b;
// bool b2;


// //variable
// int myCount = 4;
// string aName = "bob";


// //var
// var anotherCount = 4; //takes on the property of the first item in the variable
//                       //in general, just use var


// //Printing Variables
// Console.Write("Whats your age?");

// //ReadLine
// var ageString = Console.ReadLine();
// System.Console.WriteLine($"My age is {ageString}.");

// //Converting Variables
// int age = int.Parse(ageString);

// //conditionals
// if (age < 18)
//     System.Console.WriteLine("You're a minor");