using System;

public class Entry
{
    public int Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry(int date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }
    public Entry(string prompt, string response)
     {   Date = DateTime.Now.DayOfYear;
        Prompt = prompt;
        Response = response;
    }
    public string DisplayEntry()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}";
    }
}