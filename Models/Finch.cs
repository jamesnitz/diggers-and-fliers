using System;

namespace Diggers_and_fliers
{
  public class Finch : IFly
  {
    public string Species { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public string Food { get; set; }
    public bool Flier { get; set; }
    public void Flying()
    {
      Console.WriteLine("Finches be flying");
    }
  }
}
