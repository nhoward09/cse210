class Scripture
{

    private List<Word> wordList;
    private Random random;
    private Reference reference;
    private int hiddenCount;

    public Scripture(string text, Reference reference)
    {
        wordList = new();

        // Split the text into words
        string[] words = text.Split(' ');

        foreach (string letters in words)
        {
            var temp = new Word(letters);

            wordList.Add(temp);
        }

        random = new Random();

        hiddenCount = 0;
        this.reference = reference;
    }

    public int wordsLeft()
    {
        return wordList.Count - hiddenCount;
    }

    public void HideWords()
    {
        Word randomWord = wordList[random.Next(0, wordList.Count)];

        if (randomWord.WordChecker() == false)
        {
            randomWord.ReplaceLetters();

            hiddenCount++;
        }
        else
        {
            HideWords();
        }
    }



    public void Display()
    {
        reference.Display();
        foreach (Word word in wordList)
        {
            word.Display();
        }
    }
}