using System;
using System.Collections.Generic;
using System.Text;
using FoodDiary.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Linq;


namespace FoodDiary.Presenter
{
    //Class designed to work with the DB for the Ingredient object
    class IngredientsInput
    {
        Ingredient ingr = new Ingredient();
        IngredientDB ingrBD;

        public IngredientsInput()
        {
            ingrBD = new IngredientDB();
        }

        /// <summary>
        /// Loading from the database the list of ingredients
        /// </summary>
        /// <returns></returns>
        public List<IngredientDB> IngredientLoad()
        {
            using (DataBaseFoodDiaryContext context = new DataBaseFoodDiaryContext())
            {
                var listIngredientsOrDishes = context.IngredientDB.ToList();
                return listIngredientsOrDishes;
            }
        }
        /// <summary>
        /// Delete item
        /// </summary>
        /// <param name="item">ingredient</param>
        public void RemoveIngredient(IngredientDB item)
        {
            using (DataBaseFoodDiaryContext context = new DataBaseFoodDiaryContext())
            {
                context.IngredientDB.Remove(item);
                context.SaveChanges();
            }
        }
        /// <summary>
        /// Adding a new record to the database
        /// </summary>
        public void AddIngredients(string name, float protein, float fat, float carboh)
        {
            using (DataBaseFoodDiaryContext context = new DataBaseFoodDiaryContext())
            {
                ingrBD.Name = name;
                ingrBD.Protein = protein;
                ingrBD.Fat = fat;
                ingrBD.Carbohydrate = carboh;
                ingrBD.Id = NextAfterLastIndex();
                ingrBD.EnergyValue = ingr.EnergyValueMethod((float)ingrBD.Protein, (float)ingrBD.Fat, (float)ingrBD.Carbohydrate);
                var listIngredientsOrDishes = context.IngredientDB.ToList();
                context.IngredientDB.Add(ingrBD);
                context.SaveChanges();

            }
        }
        /// <summary>
        /// Find the last index in the database and return the next one by value
        /// </summary>
        /// <returns></returns>
        int NextAfterLastIndex()
        {
            using (DataBaseFoodDiaryContext context = new DataBaseFoodDiaryContext())
            {
                int max = context.IngredientDB.Max(i => i.Id);
                return max + 1;
            }
        }
    }
}
