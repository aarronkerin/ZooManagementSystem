using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.BusinessLogic.Models.Animals
{
    public class Giraffe : Animal, ICanBeGroomed
    {
        private DateTime lastGroomed;
        public Giraffe(DateTime dateOfBirth) : base(dateOfBirth)
        {
        }

        public override void Feed()
        {
            Console.WriteLine("<Munch, munch>");
            base.Feed();
        }
        public void Groom()
        {
            lastGroomed = DateTime.Now;
        }

        public override string ToString()
        {
            return base.ToString() + $"; Last Groomed {lastGroomed}";
        }
    }

}
