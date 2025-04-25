using System;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string grade = Console.ReadLine();
        int gradeInt = int.Parse(grade);
        Console.WriteLine();

        if (gradeInt >= 90)
        {
            Console.WriteLine("You got an A!");
        }
        else if (gradeInt >= 80)
        {
            Console.WriteLine("You got a B!");
        }
        else if (gradeInt >= 70)
        {
            Console.WriteLine("You got a C!");
        }
        else if (gradeInt >= 60)
        {
            Console.WriteLine("You got a D!");
        }
        else
        {
            Console.WriteLine("You got an F!");
        }
    }

}