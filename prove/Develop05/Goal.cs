using System.Security.Cryptography.X509Certificates;

class Goal
{
    private string title;
    private string description;
    protected int points;
    protected bool isComplete;

    public virtual string Display() {
        return $"[{(isComplete?"X":" ")}] {title} ({description})";
    }
    public virtual int RecordEvent() {
        if (!isComplete){
            isComplete = true;
            return points;
        }
        return 0;
    }

    public virtual string Export()
    {
        return $":{title}||{description}||{points}||{isComplete}";
    }

    public string DisplayShort(){
        return title;
    }

    public Goal(string title, string description, int points) {
        this.title = title;
        this.description = description;
        this.points = points;
    }
    public Goal(string loadString){
        string[] parts = loadString.Split("||");
        title = parts[0];
        description = parts[1];
        points = int.Parse(parts[2]);
        isComplete = bool.Parse(parts[3]);
    }
}