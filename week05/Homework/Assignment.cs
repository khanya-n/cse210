public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    protected void SetName(string name)
    {
        _studentName = name;
    }

    protected void SetTopic(string topic)
    {
        _topic = topic;
    }

    protected string GetName()
    {
        return _studentName;
    }
}