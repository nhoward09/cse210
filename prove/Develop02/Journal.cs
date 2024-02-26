public class Journal
{
    public List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public Journal(string importString)
    {

    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void Display()
    {
        foreach (var entry in entries)
        {
            System.Console.WriteLine(entry.Display());
        }
    }

    public void Save(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (var entry in entries)
            {
                outputFile.WriteLine(entry.Export());
            }
        }
    }

    public void Load(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            var entry = new Entry(parts[2], parts[1], parts[0]);
            this.AddEntry(entry);
        }
    }
}