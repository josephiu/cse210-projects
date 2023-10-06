
public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string title, string studentname, string topic) : base (studentname, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        // Notice that we are calling the getter here because _studentName is private in the base class
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }

}