using System;

class Program
{
    static void Main(string[] args)
    {
        bool isFinished = false;
        FileReader reader = new FileReader("scriptures.csv");
        List<Scripture> scriptures = reader.ReadScripturesFromFile();
        Random randomGen = new Random();
        int scriptureIndex = randomGen.Next(0, scriptures.Count);

        Scripture scripture = scriptures[scriptureIndex];

        do
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit" || scripture.IsCompletelyHidden())
            {
                isFinished = true;
            }
            else
            {
                scripture.HideWords();
                Console.Clear();
            }
        }
        while (!isFinished);
    }
}