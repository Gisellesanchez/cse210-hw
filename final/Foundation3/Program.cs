using System;
using Foundation3;
class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("125 South Owen", "Madison", "WI", "USA");
        Address address2 = new Address("456 Elm St", "Middleton", "WI", "USA");
        Address address3 = new Address("789 Oak St", "Verona", "WI", "USA");

        Event lecture = new Lecture("Tech Knowledge", "A talk on the latest in technology.",
            new DateTime(2023, 5, 20), address1, "10:00 AM", "Dr. Sanchez", 100);

        Event outdoorGathering = new OutdoorGathering("Community Picnic", "A fun day in the park.",
            new DateTime(2023, 7, 10), address2, "12:00 PM", "Sunny", "Picnic Games");

        Event reception = new Receptions("Annual Gala", "A formal evening event.",
            new DateTime(2023, 9, 15), address3, "6:00 PM", "Emily Irwin", "Formal Attire","rsvp@wedding.com" );


        Event[] events = new Event[] { lecture, outdoorGathering, reception };

        foreach (Event ev in events)
        {
           
            Console.WriteLine("");
            Console.WriteLine("\n    Standard Event Description:   ");
             Console.WriteLine("");
            Console.WriteLine(ev.GetSmallDescription());
            Console.WriteLine("");
            Console.WriteLine("\n    Complete Event Description:   ");
             Console.WriteLine("");
            Console.WriteLine(ev.GetCompleteDescription());
            Console.WriteLine("");
            Console.WriteLine("\n    Short Event Description:   ");
             Console.WriteLine("");
            Console.WriteLine(ev.ToString());
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine(""); 
        }


    }
}