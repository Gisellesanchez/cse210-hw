using System;
using System.Collections.Generic;
using System.Threading;

namespace ScriptureMemorization;

class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;


    public Reference(string book, int chapter, int startVerse, int endVerse = 0)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

 public string GetDisplay()
        {

            return $"{_book} {_chapter}:{_startVerse}- {_endVerse}";


        }

    public class ScriptureLibrary
    {
        private static Dictionary<string, string> _scriptures = new Dictionary<string, string>
        {
            { "Proverbs 3:5-6", "Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths." },
            { "John 3:16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life." },
            { "2 Nephi 2:25", "Adam fell that men might be; and men are, that they might have joy." }
            // Add more verses here
        };
        public static string GetVerse(string reference)
        {
            if (_scriptures.TryGetValue(reference, out string verse))
            {
                return verse;
            }
            else
            {
                return "Reference not found.";
            }
        }

    }
}
