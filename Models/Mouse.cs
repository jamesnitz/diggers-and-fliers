using System;

namespace Diggers_and_fliers
{
  public class Mouse : IMove
  {
    public string Species { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public string Food { get; set; }
    public bool Mover { get; set; }
    public void Moving()
    {
      Console.WriteLine("mice be moving");
    }

  }
}
