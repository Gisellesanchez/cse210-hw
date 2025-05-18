using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;



public class Journal
{
    public List<Entry> Entries { get; set; }
    private Prompt promptGenerator = new Prompt();

    public void WriteNewEntry()
    {
        string prompt = promptGenerator.GetRandomPrompt(); //Get a random prompt from the Prompt class

        string fileName = "Journal.txt"; //Call the file Journal.txt


        using (StreamWriter writer = new StreamWriter(fileName, true))
        {
            writer.WriteLine(prompt);
            writer.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        Entry entry = new Entry(DateTime.Now.DayOfYear, prompt, response);
        Entries.Add(entry); //Add the entry to the list of entries
        Console.WriteLine("Entry was added successfully!");

    }
    public void DisplayJournal()
    {
        if (Entries.Count == 0)
        {
            Console.WriteLine("Your Journal is Empty :( ");
        }
        else
        {
            foreach (Entry entry in Entries)
            {
                Console.WriteLine($"Displaying Entry: {entry.Date}");
                Console.WriteLine(entry.DisplayEntry());

            }
        }


    }
    public void SaveJournalToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
    
        {
            foreach (Entry entry in Entries)
            {
                writer.WriteLine(entry.DisplayEntry());
            }
            Console.WriteLine("Journal saved successfully!");
        }
    }

    public void LoadJournalFromFile(string fileName)
    {

        string[] lines = File.ReadAllLines(fileName);


        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
            Entries.Add(new Entry(firstName, lastName) { Date = DateTime.Now.DayOfYear });

        }
        Console.WriteLine("Journal loaded successfully!");
    }
}