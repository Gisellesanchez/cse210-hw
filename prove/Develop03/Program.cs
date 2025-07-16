using System;
using System.Collections.Generic;
using System.Threading;
using ScriptureMemorization;




class Program
{
    static void Main(string[] args)

    
    {
        Console.WriteLine();
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("Welcome to the Scripture Memorization Program!");
        Console.WriteLine();
        Console.WriteLine("Select a scripture to memorize from the list below:");  
        Console.WriteLine(); 

        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."));
        scriptures.Add(new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me."));
        scriptures.Add(new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."));
        scriptures.Add(new Scripture(new Reference("Isaiah", 41, 10), "Fear thou not; for I am with thee: be not dismayed; for I am thy God: I will strengthen thee; yea, I will help thee; yea, I will uphold thee with the right hand of my righteousness."));


        Random random = new Random();
        int scriptureIndex = random.Next(scriptures.Count);
        Scripture currentScripture = scriptures[scriptureIndex];


        Console.WriteLine(currentScripture.GetDisplay());

        Console.WriteLine();
        Console.WriteLine("Press Enter to hide a random word, or type 'quit' to exit.");
        string input = Console.ReadLine();


        Console.WriteLine();

        while (input.ToLower() != "quit")
        {
            currentScripture.HideRandomWord(1);
            Console.Clear();
            Console.WriteLine("Here is the scripture with a word hidden:");

            Console.WriteLine();
            Console.WriteLine(currentScripture.GetDisplay());

            if (currentScripture.GetDisplay().Contains("_"))
            {
                Console.WriteLine("Press Enter to hide another word, or type 'quit' to exit.");
            }
            else
            {
                Console.WriteLine("All words are hidden! Type 'quit' to exit.");
            }

            input = Console.ReadLine();
        }
        
        
    }
}