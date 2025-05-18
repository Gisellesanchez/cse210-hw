using System;

class Program
{
    static void Main(string[] args)
    {

        Journal journal = new Journal(); //Creating a new instance of the Journal class
        Menu menu = new Menu();//Grabbing the menu class from the Menu.cs file
        menu.DisplayTitle();
        menu.DisplayMenu();
        string choice = menu.GetInput();

        bool running = true;

        while (running)
            
        {
            switch (choice)
            {
                case "1":
                    journal.WriteNewEntry();
                    break;
                case "2":
                    journal.DisplayJournal();
                    break;
                case "3":
                    Console.Write("Enter the file name to save the journal: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveJournalToFile(saveFile);
                    break;
                case "4":
                    Console.Write("Enter the file name to load the journal: ");
                    journal.LoadJournalFromFile(Console.ReadLine());
                    Console.WriteLine("Journal loaded successfully!");
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            menu.DisplayMenu();
            choice = menu.GetInput();
        }
        Console.WriteLine("Thank you for using the Journal Program!");
        Console.WriteLine("Goodbye!");
   
        
    }
}