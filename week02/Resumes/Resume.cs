public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display() //same goes for here, NO 'static' keyword... it messes up direct inputting of variables
    {
        Console.WriteLine("Name: " + _name);
        Console.WriteLine("Jobs:");
        foreach (var occupation in _jobs)
        {
            occupation.Display();
        }
    }

}
