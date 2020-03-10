using System;

namespace Diggers_and_fliers
{
  public class BettaFish : ISwim
  {
    public string Species { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public string Food { get; set; }
    public bool Swimmer { get; set; }

    public void Swimming()
    {
      Console.WriteLine("Bettas be swimming");
    }
  }
}
