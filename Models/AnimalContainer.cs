using System.Collections.Generic;

namespace Diggers_and_fliers
{
  public class AnimalContainer
  {
    public List<IDig> Diggers = new List<IDig>();
    public List<IFly> Fliers = new List<IFly>();
    public List<IMove> Movers = new List<IMove>();
    public List<ISwim> Swimmers = new List<ISwim>();


  }
}