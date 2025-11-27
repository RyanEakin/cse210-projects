class WritingAssignment : Assignment
{
    string _title;

    public WritingAssignment(string studentName, string topic, string title) :base(studentName,topic)
    {
        _title = title;

    }
    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        string topic = GetTopic();

        string writtenString = $"{studentName} - {topic} \n{_title} by {studentName}";
        return writtenString;
    }

}