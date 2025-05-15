using System;

class Menu
{
    public void DisplayTitle()


    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine(" Write, Display, Save and Load your Journal Entries");
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("This program allows you to create and manage your journal entries.");
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Please select an option:");
        Console.WriteLine();
        Console.WriteLine("1. Create a new journal entry");
        Console.WriteLine("2. View existing journal entries");
        Console.WriteLine("3. Exit");
    }
}