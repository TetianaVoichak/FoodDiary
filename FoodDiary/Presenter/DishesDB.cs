using System;
using System.Collections.Generic;
using System.Text;
using FoodDiary.Model;

namespace FoodDiary.Presenter
{
    class DishesDB : IngredientsInput
    {
        public Dish dish;
        string name;
        int countDish;
        List<Ingredient> ingredientsList = null;
        public string Name
        {
            get { return name; }
        }
        public DishesDB(Dish dish)
        {
            this.dish = dish;
        }
        public DishesDB()
        {
            IngredientsInput ingr = new IngredientsInput();
        }
        public DishesDB(string name, List<Ingredient> list, int countDish)
        {
            this.name = name;
            ingredientsList = list;
            this.countDish = countDish;
        }
        public void RemoveIngredient(Ingredient item)
        {
            ingredientsList.Remove(item);
        }
        public void AddIngredients(Ingredient item)
        {
            ingredientsList.Add(item);
        }
        public void SaveDish()
        {

        }

    }
}
