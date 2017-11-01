using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.BusinessLogic.Models.Animals
{
    public class Giraffe : AnimalThatCanBeGroomed
    {
        public Giraffe(DateTime dateOfBirth) : base(dateOfBirth)
        {
        }
    }
}
