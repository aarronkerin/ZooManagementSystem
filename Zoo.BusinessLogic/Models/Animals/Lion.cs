using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.BusinessLogic.Models.Animals
{
  public class Lion : Animal, ICanBeCleanedOut
  {
        private DateTime lastCleaned;
        public Lion(DateTime dateOfBirth) : base(dateOfBirth)
    {
    }

      public override string ToString()
      {
       return base.ToString() + $"; Last Cleaned {lastCleaned}";

      }

      public void Cleaned()
      {
          lastCleaned = DateTime.Now;
      
       }
    }
  }

