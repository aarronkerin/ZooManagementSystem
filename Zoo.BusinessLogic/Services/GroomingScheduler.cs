using System;
using System.Collections.Generic;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Services
{
  public class GroomingScheduler : IScheduler
  {
    private static GroomingScheduler instance;

    public static GroomingScheduler Instance
    {
      get
      {
        if (instance == null)
        {
          instance = new GroomingScheduler();
        }

        return instance;
      }
    }

    private GroomingScheduler()
    {
    }

    public void AssignJobs(IEnumerable<Keeper> keepers, IEnumerable<Animal> animals)
    {
      foreach (var keeper in keepers)
      {
        foreach (var animal in keeper.GetResponsibleAnimals())
        {
          var groomableAnimal = animal as ICanBeGroomed;

          if (groomableAnimal != null)
          {
            keeper.GroomAnimal(groomableAnimal);
          }
        }
      }
    }

        public void display()
        {
           Console.WriteLine("Grooming the animals..");
        }
    }
}