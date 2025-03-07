using System;
using System.IO;
using System.Collections.Generic;



// ****Entry Class****
public class Entry
 {

    // エントリーのプロパティ
    public string Prompt {get ; set; }
    public string Response {get ; set; }
    public string Date {get ; set; }

    // constracter
    public Entry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    // Display entry
    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine();
    }

    // Format for saving
    public string FormatForSaving()
    {
        return $"{Date}~|~{Prompt}~|~{Response}";
    }

 }




//  **** Journal Class ****
// (日記全体を管理する)
public class Journal
{
    private List<Entry> _entries;
    private List<string> _prompts;
    private Random _random;


    // ** constracter
    public Journal()
    {
        // 空のエントリーリストを初期化
        _entries = new List<Entry>();
        // 質問リストを初期化
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What am I grateful for today?",
            "What did I learn today?",
            "What challenge did I overcome today?"           
        };

        //ランダムオブジェクトを初期化
        _random = new Random();
    }


    // ** Add new entry
    public void AddEntry()
    {
        // get random prompt
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");

        // get response
        Console.WriteLine("Your response: ");
        string response = Console.ReadLine();

        // get date
        string date = DateTime.Now.ToShortDateString();

        // Create and add new entry
        Entry entry = new Entry(prompt, response, date);
        _entries.Add(entry);

        Console.WriteLine("Entry added successfully:)");
    }

    // ** get random prompt
    private string GetRandomPrompt()
    {
        // 0から(質問リストの長さ-1)までのランダムなインデックスを生成
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    //** Display all entries
    public void DisplayEntries()
    {
        // エントリーがない場合
        if(_entries.Count == 0)
        {
            Console.WriteLine("No enteries to display.");
            return;
        }

        Console.WriteLine("Journal Entries:");
        Console.WriteLine("==================");


        // 各エントリーを表示
        foreach(Entry entry in _entries)
        {
            entry.Display();
        }
    }


    // ** Save to file
    public void SaveToFile()
    {
        // エントリーがない場合
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to save.");
            return;
        }
         // ファイル名をユーザーに尋ねる
        Console.WriteLine("Enter filename to save: ");
        string fileName = Console.ReadLine();

        try
        {
            // StreamWriterを使ってファイルに書き込む
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine(entry.FormatForSaving());
                }
            }
            
            Console.WriteLine($"Journal saved to {fileName} successfully!");
        }
        catch (Exception ex)
        {
            // エラーが発生した場合
            Console.WriteLine($"Error saving file: {ex.Message}");
        }
    }


    // ** Lord from file
    public void LoadFromFile()
    {
        // ask file name to the user
        Console.WriteLine("Enter filename to load: ");
        string fileName = Console.ReadLine();

        // If file doesn't exist
        if(!File.Exists(fileName))
        {
            Console.WriteLine($"File {fileName} does not exist.");
            return;
        }

        try
        {
            // ファイルのすべての行を読み込む
            string[] lines = File.ReadAllLines(fileName);
            
            // 既存のエントリーをクリア
            _entries.Clear();
            
            // 各行を処理
            foreach (string line in lines)
            {
                // ~|~で分割
                string[] parts = line.Split("~|~");
                
                // 正しい形式かチェック
                if (parts.Length == 3)
                {
                    string date = parts[0];
                    string prompt = parts[1];
                    string response = parts[2];
                    
                    // 新しいエントリーを作成して追加
                    Entry entry = new Entry(prompt, response, date);
                    _entries.Add(entry);
                }
            }
            
            Console.WriteLine($"Loaded {_entries.Count} entries from {fileName}");
        }
        catch (Exception ex)
        {
            // エラーが発生した場合
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
    }
}



// **** Program Class ****
class Program
{
    static void Main(string[] args)
    {
        // create new journal object
        Journal journal = new Journal();
        bool quit = false;


        // main loop
        while (!quit)
        {
            // display menu
            Console.WriteLine("\n===== Welcome to your journal! =====");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");


            // get the user's choice
            string choice = Console.ReadLine();
            Console.WriteLine();

            // 選択に基づいて処理
            switch (choice)
            {
                case "1":
                    journal.AddEntry();
                    break;

                case "2":
                    journal.DisplayEntries();
                    break;  
                
                case "3":
                    journal.SaveToFile();
                    break;
                
                case "4":
                    journal.LoadFromFile();
                    break;
                
                case "5":
                    quit = true;
                    break;
                
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;

            }
        }

        Console.WriteLine("Thank you!");

    }
}