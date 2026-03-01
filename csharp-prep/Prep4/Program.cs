using System;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;

        // I added a do while loop here because I think it's better this way.
        do
        {
            Console.Write("Enter a number, enter 0 to end: ");
            string input = Console.ReadLine();
            userNumber = int.Parse(input);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        }
        while (userNumber != 0);

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum of all the numbers is: {sum}");

        float averageNum = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average of all numbers is: {averageNum}");

        int highest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > highest)
            {
                highest = number;
            }
        }

        Console.WriteLine($"The highest number is: {highest}");

    }
}