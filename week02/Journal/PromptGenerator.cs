public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What is the most interesting thing I learned today?",
        "What was the best part of my day?",
        "What was the strongest emotion I felt today?",
        "Is there anything I regret doing today?",
        "What did I spend the day doing?",
        "Where was I for most of the day?"
    };

    public string GetRandomPrompt()
    {
        Random indexGenerator = new Random();
        int index = indexGenerator.Next(0, _prompts.Count-1);

        return _prompts[index];
    }
}