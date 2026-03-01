using System;

class Program
{
    static void Main()
    {
        displayWecomeMessage();

        string userName = promptUserName();
        int userNumber = promptUserNumber();
        int squareNumber = squaredNumber(userNumber);
        int birthYear;
        promptUserBirthYear(out birthYear);
       
        displayResults(userName, squareNumber, birthYear);
    }

    static void displayWecomeMessage()
    {
        Console.WriteLine("Welcome to my program");
    }

    static string promptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }

    static int promptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static void promptUserBirthYear(out int birthYear)
    {
        Console.Write("What year were you born? ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int squaredNumber(int number)
    {
        int squareNum = number * number;
        return squareNum;
    }

    static void displayResults(string name, int squareNum, int birthYear)
    {
        Console.WriteLine($"Hello {name}, the square of the number you entered is {squareNum}.");
        Console.WriteLine($"{name}, you will also be turning {2026 - birthYear} years old this year.");
    }

}