using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDiary
{
    internal class Dish: EnergyValueClass
    {
       string name;
       List<Ingredient> ingredients = null;
        
      public Dish(string name) :base()
      {
            this.name = name;
           
      }
    }
}
