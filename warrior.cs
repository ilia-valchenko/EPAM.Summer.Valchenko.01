using System;

namespace Game
{
    public class Warrior
    {
      public int Health {get;set;}

      public string GetInfo() {
        return String.Format("Your character is warrior.");
      }
    }
}
