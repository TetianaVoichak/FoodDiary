using System;
using System.Collections.Generic;
using System.Text;
using FoodDiary.Model;
using Microsoft.EntityFrameworkCore;


namespace FoodDiary.Presenter
{
    class IngredientsDB //: DbContext
    {
        public List<Ingredient> ingredients;

        List<Ingredient> ingredientsList = new List<Ingredient>();

        public DbSet<Ingredient> Ingredients { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; DateBase = DataBaseFoodDiary; Trusted_Connection=True");

        //}
        public IngredientsDB(Ingredient ingredient)
        {

            ingredients.Add(ingredient);
        }
        public IngredientsDB()
        {
            Ingredient ingredient_my = new Ingredient(1, "Помидор", 0.6, 0.2, 4.2);
            ingredientsList.Add(ingredient_my);


            ingredient_my = new Ingredient(2, "Огурец", 0.8, 0.1, 2.8);
            ingredientsList.Add(ingredient_my);

            ingredient_my = new Ingredient(3, "Сметана Президент 15%", 2.6, 15, 3.9);
            ingredientsList.Add(ingredient_my);
        }

        void RemoveIngredient(Ingredient item)
        {
            ingredientsList.Remove(item);
        }
        void AddIngredients(Ingredient item)
        {
            ingredientsList.Add(item);
        }

      
    }
}
