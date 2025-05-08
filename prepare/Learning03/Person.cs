using System;


public class Person
{
    public string _givenName = "";
    public string _familyName = "";

    public Person()
    {

    }
    public void ShowEasternName()
{
    Console.WriteLine($"{_familyName}, {_givenName}");

}
    public void ShowWesternName()
    {
        Console.WriteLine($"Hello{_givenName} {_familyName}");


    }
}