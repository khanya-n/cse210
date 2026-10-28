using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int numberItem;
        List<int> numbers = new List<int>();
        int sum = 0;
        int largest = 0;
        float average;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            numberItem = int.Parse(Console.ReadLine());

            if (numberItem != 0)
            {
                numbers.Add(numberItem);
            }
        }
        while (numberItem != 0);

        foreach (int number in numbers)
        {
            sum += number;

            if (number > largest)
            {
                largest = number;
            }
        }

        average = sum / numbers.Count;
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}