using System;

namespace Diggers_and_fliers
{
  public class Ant : IDig
  {
    public string Species { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public string Food { get; set; }
    public bool Digger { get; set; }

    public void Digging()
    {
      Console.WriteLine("Ants be digging");
    }
  }
}
