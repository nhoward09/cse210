public class Entry
{
    public string response;
    public string prompt;
    public string date;

    public Entry(string response, string prompt)
    {
        this.date = DateTime.Now.ToShortDateString();
        this.response = response;
        this.prompt = prompt;
    }

    public Entry(string response, string prompt, string date)
    {
        this.date = date;
        this.response = response;
        this.prompt = prompt;
    }

    public string Display()
    {
        return $"{date}: {prompt}\n{response}\n";
    }

    public string Export()
    {
        return $"{date}|{prompt}|{response}\n";
    }
}