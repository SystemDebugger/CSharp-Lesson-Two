// See https://aka.ms/new-console-template for more information.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        string myName = "Allendro";
        Console.WriteLine("Hello, " + myName);
        int myAge = 16;
        double myHeight = 5 + (5.0 / 12.0);
        Console.WriteLine($"I am {myAge} years old and {myHeight} feet tall.");
        Console.WriteLine("\nWhat is your name?");
        Info();
    }

    static void Info()
    {
        string name = Console.ReadLine();

        if (name.ToLower() == "allendro")
        {
            Console.WriteLine("\nThat is my name, please try again.");
            Info();
        }
        else if (name != null)
        {
            Console.WriteLine("\nHello " + name + ", nice to meet you!");
        }
        else
        {
            Console.WriteLine("\nYou haven't entered a name. Are you sure?");
            string res = Console.ReadLine();
            if (res.ToLower() == "yes")
            {
                Console.WriteLine("\nHello, nice to meet you!");
            }
            else
            {
                Console.WriteLine("\nAlright, let's get you a name.");
                Info();
            }
        }
    }
}