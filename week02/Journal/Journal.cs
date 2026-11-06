using System.Text.Json;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string fileName)
    {
        using FileStream fileStream = File.OpenWrite(fileName);
        using var writer = new Utf8JsonWriter(fileStream, new JsonWriterOptions {Indented = true});

        writer.WriteStartArray();

        foreach (Entry entry in _entries)
        {
            writer.WriteStartObject();
            writer.WriteString("date", entry._date);
            writer.WriteString("prompt", entry._promptText);
            writer.WriteString("entry", entry._entryText);
            writer.WriteEndObject();
        }

        writer.WriteEndArray();
        writer.Flush();
    }

    public void LoadFromFile(string fileName)
    {
        using FileStream fileStream = File.OpenRead(fileName);
        using JsonDocument document = JsonDocument.Parse(fileStream);

        foreach (JsonElement element in document.RootElement.EnumerateArray())
        {
            Entry entry = new Entry
            {
            _date = element.GetProperty("date").GetString(),
            _promptText = element.GetProperty("prompt").GetString(),
            _entryText = element.GetProperty("entry").GetString()   
            };

            _entries.Add(entry);
        }
    }
}