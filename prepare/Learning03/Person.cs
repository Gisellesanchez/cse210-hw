using System;


public class Person
{
    public string _givenName = "Happiness";
    public string _familyName = "dino";

    public Person()
    {
    
    Person person = new Person();
    person._givenName = "Joseph";
    person._familyName = "Smith";
    person.ShowWesternName();
    person.ShowEasternName(); 
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