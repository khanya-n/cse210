using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool running = true;

        do
        {
            Console.WriteLine("""
            Welcome to The Journal!
            Please select an option:
            1. Write
            2. Display
            3. Load
            4. Save
            5. Quit
            """);
            Console.WriteLine("What would you like to do? ");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                PromptGenerator generator = new PromptGenerator();
                DateTime currentTime = DateTime.Now;
                string prompt = generator.GetRandomPrompt();
                string date = currentTime.ToShortDateString();
                Console.WriteLine($"Date: {date} | Prompt: {prompt}");
                string entryText = Console.ReadLine();
                Entry entry = new Entry
                {
                    _date = date,
                    _promptText = prompt,
                    _entryText = entryText
                };
                journal.AddEntry(entry);
            }
            else if (option == 2)
            {
                journal.DisplayAll();
            }
            else if (option == 3)
            {
                journal.LoadFromFile("");
            }
            else if (option == 4)
            {
                journal.SaveToFile("");
            }
            else if (option == 5)
            {
                Console.WriteLine("Goodbye!");
                running = false;
            }
            
        } while (running);

        
    }
}