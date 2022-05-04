using System;
using System.IO;


/* This is my first testing with C#.
It is a small console application which say hello to the user */

namespace HelloYou
{

    class Hello
    {


        static void Main(string[] args)
        {
            // Initialize
            string? name;

            // Try to say hello and ask name
            System.Console.WriteLine("Hello .. What was your name again?");

            // Get name from user via console
            name = Console.ReadLine();

            // Check if the string is null or empty and keep asking the name
            while (String.IsNullOrEmpty(name))
            {
                Console.Clear();
                System.Console.WriteLine("Sorry I did not catch your name. Please repeat");
                name = Console.ReadLine();
            }

            // Write Hello with the given name to console
            System.Console.WriteLine("Hello " + name + ". Nice to meet you!");

        }
    }
}
