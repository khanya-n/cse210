using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment baseAssignment = new Assignment("Samuel Bennet", "Mutilplication");
        Console.WriteLine($"{baseAssignment.GetSummary()}\n");

        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine($"{mathAssignment.GetHomeworkList()}\n");

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}