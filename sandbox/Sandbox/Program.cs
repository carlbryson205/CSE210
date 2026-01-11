using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        Console.WriteLine("What is your first name? ");
        string fname = Console.ReadLine();
        Console.WriteLine("What is your last name? ");
        string lname = Console.ReadLine();

        Console.WriteLine($"Your name is {lname}, {fname} {lname}.");

        Console.WriteLine("_______________________");


        Console.WriteLine("What is your grade? ");

        string valueInText = Console.ReadLine();
        int grade = int.Parse(valueInText);

        string gradeLetter = "LOGIC FAIL";

        if (grade >= 90)
        {
            gradeLetter = "A";
            Console.WriteLine("You passed!");
        }
        else if (grade >= 80)
        {
            gradeLetter = "B";
            Console.WriteLine("You passed!");
        }
        else if (grade >= 70)
        {
            gradeLetter = "C";
            Console.WriteLine("You passed!");
        }
        else if (grade >= 70)
        {
            gradeLetter = "D";
            Console.WriteLine("You passed!");
        }
        else
        {
            gradeLetter = "F";
            Console.WriteLine("You failed!");
        }

        Console.WriteLine($"Your grade is: {gradeLetter}");
    }
}