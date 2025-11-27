class MathAssignment : Assignment {
    string _textbookSection;
    string _problems;


    public MathAssignment(string studentName, string topic, string textBookSections, string problems) :base(studentName,topic)
    {
        _textbookSection = textBookSections;
        _problems = problems;
    }

    
    public string GetHomeworkList()
    {
        string mathTest = $"{_textbookSection} - {_problems}";
        return mathTest;
    }
}