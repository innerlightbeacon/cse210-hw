public class Assignment
{
    private string _studentName;
    private string _topic;

    // Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Allow child classes to access student name
    public string GetStudentName()
    {
        return _studentName;
    }

    // Return summary
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}
