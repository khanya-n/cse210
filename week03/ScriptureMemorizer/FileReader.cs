using CsvHelper;

public class FileReader
{
    private string _fileName;

    public FileReader(string fileName)
    {
        _fileName = fileName;
    }

    public List<Scripture> ReadScripturesFromFile()
    {
        List<Scripture> scriptures = new List<Scripture>();
        using CsvReader reader = CsvReader.FromFile(_fileName);
        reader.ReadHeader();
        
        while (reader.Read())
        {
            string book = reader.Parse<string>(0);
            int chapter = reader.Parse<int>(1);
            string verse = reader.Parse<string>(2);
            string text = reader.Parse<string>(3);

            Reference reference;

            if (verse.Contains('-'))
            {
                string[] splitVerse = verse.Split("-");
                int start = int.Parse(splitVerse[0]);
                int end = int.Parse(splitVerse[1]);
                reference = new Reference(book, chapter, start, end);
            }
            else
            {
                int verseNum = int.Parse(verse);
                reference = new Reference(book, chapter, verseNum);
            }

            scriptures.Add(new Scripture(reference, text));
        }

        return scriptures;
    }
}