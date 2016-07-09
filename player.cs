using System;

namespace Game
{
  public class Player {
    public string Name {get;set;}

    public string GetInfo() {
      return String.Format("Player's name: {0}", Name);
    }
  }
}
