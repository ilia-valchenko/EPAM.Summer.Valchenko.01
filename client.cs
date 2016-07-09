using System;
using Game;

class Program
{
    static void Main()
    {
       Player aragorn = new Player();
       aragorn.Name = "Aragorn";
       Console.WriteLine(aragorn.GetInfo());

       // Magician gandalf = new Magician();
       // Console.WriteLine(gandalf.GetInfo());

       Warrior gimli = new Warrior();
       Console.WriteLine(gimli.GetInfo());

       Console.WriteLine("\nTap to continue...");
       Console.ReadLine();
    }
}
