using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Services
{
   public class CleaningScheduler
    {
        private static CleaningScheduler instance;

        public static CleaningScheduler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CleaningScheduler();
                }

                return instance;
            }
        }

        private CleaningScheduler()
        {
        }

        public void AssignCleaningJobs(IEnumerable<Keeper> keepers, IEnumerable<Animal> animals)
        {
            foreach (var keeper in keepers)
            {
                foreach (var animal in keeper.GetResponsibleAnimals())
                {
                    if (animal.IsHungry())
                    {
                        keeper.FeedAnimal(animal);
                    }
                }
            }
        }
    }
}
    
