using System.Collections.Generic;
using System;
using System.Transactions;
class Program
{
    static void Main()
    {

        //Practice Prep 4
        // List<int> numbers = new List<int>();
        // List<string> words = new List<string>();
        
        // words.Add("phone");
        // words.Add("keyboard");
        // words.Add("mouse");

        // Console.WriteLine(words.Count);

        // foreach (string word in words)
        // {
        //     Console.WriteLine(word);
        // }

        // for (int i = 0; i < words.Count; i++)
        // {
        //     Console.WriteLine(words[i]);

        // }
    
    List<int> numbers = new List<int>();
    int input;

    Console.WriteLine("Enter a list of numbers, type 0 when you are finished.");

    do
    {
        Console.Write("Enter number here: ");
        input = int.Parse(Console.ReadLine());

        if (input !=0)

        {
            numbers.Add(input);
        }

    } 
    while (input != 0);
 

   
    }
}