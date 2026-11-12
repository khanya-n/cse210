public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = GetWords(text);
    }

    private List<Word> GetWords(string text)
    {
        List<Word> words = new List<Word>();
        string[] wordsText = text.Split(" ");

        foreach (string wordText in wordsText)
        {
            Word word = new Word(wordText);
            words.Add(word);
        }

        return words;
    }

    public string GetDisplayText()
    {
        string text = $"{_reference.GetDisplayText()} ";

        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }

        return text.TrimEnd();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }

    private Word SelectRandomWord()
    {
        Random random = new Random();
        int randomWordIndex = random.Next(0, _words.Count);
        
        return _words[randomWordIndex];
    }

    public void HideWords()
    {
        bool continueSearch = true;
        do
        {
            Word firstWord = SelectRandomWord();
            Word secondWord = SelectRandomWord();
            if (!firstWord.IsHidden() && !secondWord.IsHidden())
            {
                firstWord.Hide();
                secondWord.Hide();
                continueSearch = false;
            }
        }

        while (continueSearch);
    }
}