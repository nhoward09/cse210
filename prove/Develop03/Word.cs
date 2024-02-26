class Word
{
    private string letters;

    private bool isHidden;

    public bool WordChecker()
    {
        return isHidden;
    }

    public Word(string letters)
    {
        this.letters = letters;
        isHidden = false;
    }

    public void ReplaceLetters()
    {
        isHidden = true;

        letters = new string('_', letters.Length);
    }

    public void Display()
    {
        System.Console.Write(letters + " ");
    }
}