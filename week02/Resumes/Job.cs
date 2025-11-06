public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    // these variables are dynamic or generated at runtime... DO NOT place 'static' anywhere near them!
    // oh and make sure that if you are going to reference ANY variable within another Class via dot operator. make them 'public'.

    public void Display() //same goes for here, NO 'static' keyword... it messes up direct inputting of variables
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}