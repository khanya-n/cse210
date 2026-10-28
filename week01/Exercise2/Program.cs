using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());
        string letterGrade;

        if (grade >= 90)
        {
            letterGrade = "A";
        } 
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        int remainder = grade % 10;

        if (remainder >= 7 && !(letterGrade == "A") && !(letterGrade == "F"))
        {
            letterGrade += "+";
        }
        else if (remainder < 3 && !(letterGrade == "F"))
        {
            letterGrade += "-";
        }

        Console.WriteLine($"Your grade is {letterGrade}.");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed.");
        }
        else
        {
            Console.WriteLine("You have unfortunately failed. Please try again next time.");
        }
    }
}