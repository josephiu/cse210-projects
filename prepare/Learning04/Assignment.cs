using System.Dynamic;
public class Assignment
{
    private String _studentName;
    private String _topic;

    public Assignment (string studentname, string topic)
    {
        _studentName = studentname;
        _topic = topic;
    }

// This getters are the onece that can access our variables which is private
    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }





    public string GetSummary()
    {
        return $"{_studentName } - { _topic}";
        // or return _studentName + "-" + _topic;
    }
}