using System;
using System.ComponentModel;

class Menu
{

    public  void DisplayMenu()
    {
        Console.WriteLine("Please select an option:");
        Console.WriteLine();
        Console.WriteLine("1. Write a new journal entry");
        Console.WriteLine("2. Display the Journal");
        Console.WriteLine("3. Save the journal to file");
        Console.WriteLine("4. Load the journal from the file");
        Console.WriteLine("5. Quit");

        
    }

    public string GetInput()
    {
        Console.Write("Enter your choice: ");
        return Console.ReadLine();

    }

    public void DisplayTitle()


    {
        Console.WriteLine();
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Write, Display, Save and Load your Journal Entries");
        Console.WriteLine();
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("This program allows you to create and manage your journal entries.");
    
        Console.WriteLine();

    }
}