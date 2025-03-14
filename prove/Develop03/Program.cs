using System;
using System.Collections.Generic;
using System.Linq;

// ====== Main Program class ======
class Program
{
    static void Main(string[] args)
    {
        //  single scripture
        Scripture scripture = new Scripture(
            new Reference("1 Nephi", 3, 7),
            "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."
        );

        // Main program loop
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            
            string input = Console.ReadLine();
            
            if (input.ToLower() == "quit")
            {
                break;
            }
            
            // Hide some random words
            scripture.HideRandomWords(3);
        }

        // Show final message if all words are hidden
        if (scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Yay! You've completed memorizing the scripture!");
        }
    }
}

// ====== Reference Class - represent a scripture reference (例： "1 Nephi 3:7") ======
class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    private bool _isRange;

    // Constructor for a single verse reference
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
        _isRange = false;
    }

    // Constructor for a verse range reference
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        _isRange = true;
    }

    // Returns the formatted reference string
    public string GetDisplayText()
    {
        if (_isRange)
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
    }
}

// ====== Word Class - represent a single word in the scripture ======
class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Shows the word
    public void Show()
    {
        _isHidden = false;
    }

    // Hides the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Checks if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Returns the word or underscores if it's hidden
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}

// ===== Scripture Class - represent a complete scripture with reference and text ======
class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    // Constructor (takes a reference and the scripture text)
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        // Split the text into words and create Word objects
        string[] wordArray = text.Split(' ');
        foreach (string wordText in wordArray)
        {
            _words.Add(new Word(wordText));
        }
    }

    // Checks if all words in the scripture are hidden
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }

    // Hides a specified number of random words that aren't already hidden
    public void HideRandomWords(int count)
    {
        // Get list of words that are not hidden
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        
        // If there are fewer visible words than the count, adjust the count
        int wordsToHide = Math.Min(count, visibleWords.Count);
        
        // Hide randomly selected words
        for (int i = 0; i < wordsToHide; i++)
        {
            if (visibleWords.Count == 0)
                break;
                
            int randomIndex = _random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
            visibleWords.RemoveAt(randomIndex);
        }
    }

    // Returns the formatted scripture display text
    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";
        displayText += string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return displayText;
    }
}