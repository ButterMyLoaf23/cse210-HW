using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        Console.WriteLine();

        if (number >= 97)
        {
            Console.WriteLine("Your grade is A+");
            Console.WriteLine();
        }
        else if (number >= 94)
        {
            Console.WriteLine("Your grade is A");
            Console.WriteLine();
        }
        else if (number >= 90)
        {
            Console.WriteLine("Your grade is A-");
            Console.WriteLine();
        }
        else if (number >= 87)
        {
            Console.WriteLine("Your grade is B+");
            Console.WriteLine();
        }
        else if (number >= 84)
        {
            Console.WriteLine("Your grade is B");
            Console.WriteLine();
        }
        else if (number >= 80)
        {
            Console.WriteLine("Your grade is B-");
            Console.WriteLine();
        }
        else if (number >= 77)
        {
            Console.WriteLine("Your grade is C+");
            Console.WriteLine();
        }
        else if (number >= 74)
        {
            Console.WriteLine("Your grade is C");
            Console.WriteLine();
        }
        else if (number >= 70)
        {
            Console.WriteLine("Your grade is C-");
            Console.WriteLine();
        }
        else if (number >= 67)
        {
            Console.WriteLine("Your grade is D+");
            Console.WriteLine();
        }
        else if (number >= 64)
        {
            Console.WriteLine("Your grade is D");
            Console.WriteLine();
        }
        else if (number >= 60)
        {
            Console.WriteLine("Your grade is D-");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Your grade is F");
            Console.WriteLine();
        }
    }
}