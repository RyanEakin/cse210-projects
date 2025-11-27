using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment test = new Assignment("Barry","Time-Travel");
        Console.WriteLine(test.GetSummary());

        Console.WriteLine("\n");

        MathAssignment mathTest = new MathAssignment("Allen","Math","Section 7","Problems 8-11");
        Console.WriteLine(mathTest.GetSummary());
        Console.WriteLine(mathTest.GetHomeworkList());

        Console.WriteLine("\n");
        
        WritingAssignment writtenTest = new WritingAssignment("Bruce","Engineering","the history of Thermodyanmics");
        Console.WriteLine(writtenTest.GetWritingInformation());
    }
}