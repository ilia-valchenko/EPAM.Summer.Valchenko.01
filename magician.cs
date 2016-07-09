using System;

namespace Game
{
  public class Magician
  {
    public int Mana {get;set;}

    public string GetInfo() {
      return String.Format("Your character is magician.");
    }
  }
}
