using System;
using System.Drawing;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
    //   string response;
    //   do {
    //     Console.Write("Do you want to continue?");
    //     response = Console.ReadLine();
    //    }
    //    while ( response == "yes"); 

    //    for (int i = 0; i <10; i++)
    //    {
    //     Console.WriteLine(i);
    //    }

    //    for (int i = 2; i <= 20; i = i + 2)
    //    {
    //     Console.WriteLine(i);
    //    }
    //Random Number Generator
    //   Random randomGenerator = new Random();
    //   int number = randomGenerator.Next(1, 11);
    //     Console.WriteLine("Guess a number between 1 and 10");
    //     int guess = int.Parse(Console.ReadLine());
    // 
    
    //     if (guess == number
    
//Magic Number Guess Generator


        // Console.WriteLine("What is the magic number? ");
        // string magicNumber = Console.ReadLine();
        // int magicNumberInt = int.Parse(magicNumber);
        // Console.WriteLine("What is your guess? ");
        // string guessString = Console.ReadLine();
        // int guess = int.Parse(guessString);

        // if (guess < magicNumberInt)
        // {
        //     Console.WriteLine("Too low!");
        // }
        // else if (guess > magicNumberInt)
        // {
        //     Console.WriteLine("Too high!");
        // }
        // else
        // {
        //     Console.WriteLine("You guessed it!");
        // }
   
//Loop with Magic Number 1-10
        // Random randomGenerator = new Random();
        // int magicNumber = randomGenerator.Next(1, 11);
        // int guess = 0;

        // while (guess != magicNumber)
        // {
        //     Console.WriteLine("Guess a number between 1 and 10");
        //     guess = int.Parse(Console.ReadLine());

        //     if (guess < magicNumber)
        //     {
        //         Console.WriteLine("Too low!");
        //     }
        //     else if (guess > magicNumber)
        //     {
        //         Console.WriteLine("Too high!");
        //     }
        // }
        // Console.WriteLine("You guessed it!");
 
// /// Random Number Generator  1-100
//    Random randomGenerator = new Random();
//         int magicNumber = randomGenerator.Next(1, 101);
//         int guess = 0;

//         while (guess != magicNumber)
//         {
//             Console.WriteLine("Guess a number between 1 and 100");
//             guess = int.Parse(Console.ReadLine());

//             if (guess < magicNumber)
//             {
//                 Console.WriteLine("Too low!");
//             }
//             else if (guess > magicNumber)
//             {
//                 Console.WriteLine("Too high!");
//             }
//         }
//         Console.WriteLine("You guessed it!");

//Stretch Challenge
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guess = 0;
        int guesses = 0;

        while (guess != magicNumber)
        {
            Console.WriteLine("Guess a number between 1 and 100");
            guess = int.Parse(Console.ReadLine());
            guesses++;

            if (guess < magicNumber)
            {
                Console.WriteLine("Too low!");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Too high!");
            }
        }
        Console.WriteLine($"You guessed it in {guesses} tries!");


    }
}
    
