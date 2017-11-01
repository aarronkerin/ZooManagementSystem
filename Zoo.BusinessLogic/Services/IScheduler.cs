using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Services
{
    public interface IScheduler
    {
        void display();
        void AssingJobs(IEnumerable<Keeper> keepers, IEnumerable<Animal> animals);
    }
}
