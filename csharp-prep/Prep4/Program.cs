using System;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        int number = -1;
        do
        {
            Console.Write("Enter a number, enter 0 to end: ");
            string input = Console.ReadLine();
            number = int.Parse(input);

            do
            {
                numbers.Add(number);
            }
            while (number != 0);

        }
        while (number != 0);

    }
}