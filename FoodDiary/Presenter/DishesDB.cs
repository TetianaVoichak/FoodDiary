using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDiary.Presenter
{
    class DishesDB
    {
        Dish dish = null;
        List<Ingredient> ingredientsList = null;
        public DishesDB(string name)
        {
            this.dish = new Dish(name);
        }

        public void RemoveIngredient(Ingredient item)
        {
            ingredientsList.Remove(item);
        }
        public void AddIngredients(Ingredient item)
        {
            ingredientsList.Add(item);
        }

    }
}
