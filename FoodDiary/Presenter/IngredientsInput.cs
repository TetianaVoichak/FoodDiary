using System;
using System.Collections.Generic;
using System.Text;
using FoodDiary.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Linq;


namespace FoodDiary.Presenter
{
    class IngredientsInput 
    {
        Ingredient ingr = new Ingredient();
        IngredientDB ingrBD;
        //public List<Ingredient> ingredients;

        //List<Ingredient> ingredientsList = new List<Ingredient>();
        //int value;

        //public DbSet<Ingredient> Ingredients { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; DateBase = DataBaseFoodDiary; Trusted_Connection=True");

        //}
        public IngredientsInput()
        {
            ingrBD = new IngredientDB();
        }

        /// <summary>
        /// Загрузка из БД списка ингредиентов
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
        /// Удалить элемент
        /// </summary>
        /// <param name="item"></param>
        void RemoveIngredient(IngredientDB item)
        {
            using (DataBaseFoodDiaryContext context = new DataBaseFoodDiaryContext())
            {
                var listIngredientsOrDishes = context.IngredientDB.ToList();
                context.IngredientDB.Remove(item);
                context.SaveChanges();

            }

        }
        /// <summary>
        /// Добавление новой записи в базу
        /// </summary>
        /// <param name="item"></param>
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
        /// Узнать последний индекс в базе и вернуть следующий по значению
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
