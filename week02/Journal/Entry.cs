using System;


class Entry // Single Journal Entry
{
    public string _promptText;
    public string _entryText;
    public string _date;

    public void Display()
    {
        Console.Write("Date: " + _date + " - Prompt: " + _promptText + "\n" + _entryText + "\n");
        Console.WriteLine("");
    }
}