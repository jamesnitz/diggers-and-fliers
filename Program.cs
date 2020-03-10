using System;

namespace Diggers_and_fliers
{
  class Program
  {
    static void Main(string[] args)
    {

      Ant flick = new Ant()
      {
        Digger = true
      };
      BettaFish beta = new BettaFish()
      {
        Swimmer = true
      };
      Copperhead copper = new Copperhead()
      {
        Mover = true
      };

      Earthworm jim = new Earthworm()
      {
        Digger = true
      };

      Finch fin = new Finch()
      {
        Flier = true
      };
      Gerbil gerbil = new Gerbil()
      {
        Mover = true
      };
      Mouse mouse = new Mouse()
      {
        Mover = true
      };
      Parakeet parry = new Parakeet()
      {
        Flier = true
      };
      Terrapin terry = new Terrapin()
      {
        Mover = true
      };
      TimberRattlesnake tim = new TimberRattlesnake()
      {
        Mover = true
      };
      AnimalContainer animalContainer = new AnimalContainer();

      animalContainer.Diggers.Add(flick);
      animalContainer.Diggers.Add(jim);
      animalContainer.Fliers.Add(parry);
      animalContainer.Fliers.Add(fin);
      animalContainer.Swimmers.Add(beta);
      animalContainer.Movers.Add(terry);
      animalContainer.Movers.Add(tim);
      animalContainer.Movers.Add(mouse);
      animalContainer.Movers.Add(copper);
      animalContainer.Movers.Add(gerbil);

      foreach (var item in animalContainer.Diggers)
      {
        item.Digging();
      }
      foreach (var item in animalContainer.Fliers)
      {
        item.Flying();
      }
      foreach (var item in animalContainer.Swimmers)
      {
        item.Swimming();
      }
      foreach (var item in animalContainer.Movers)
      {
        item.Moving();
      }



    }
  }
}
