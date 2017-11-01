﻿using System;
using System.CodeDom;

namespace Zoo.BusinessLogic.Models.Animals
{
    public class Rabbit : Animal, ICanBeGroomed
    {

        private DateTime lastGroomed;
    public Rabbit(DateTime dateOfBirth) : base(dateOfBirth)
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