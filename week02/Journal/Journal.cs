using System.IO;
class Journal // Entry Store
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {   
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            Console.WriteLine("Date: " + e._date + " - Prompt:" + e._promptText);
            Console.WriteLine(e._entryText);
            Console.WriteLine("");
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            
            foreach (Entry e in _entries) {
                outputFile.WriteLine(e._date + "~*|*~" + e._promptText + "~*|*~" + e._entryText + "~*|*~");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            Entry newEntry = new Entry();
            string[] writtenLines = line.Split("~*|*~");

            newEntry._date = writtenLines[0];
            newEntry._promptText = writtenLines[1];
            newEntry._entryText = writtenLines[2];
            _entries.Add(newEntry);
        }
    }
}