using System;

class Program
{
    static void Main(string[] args)
    {
        //Grabbing the menu class from the Menu.cs file
        Menu menu = new Menu();
        menu.DisplayTitle();
        menu.DisplayMenu();
        string choice = menu.GetInput();
        
    }
}