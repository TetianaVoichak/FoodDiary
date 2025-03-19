using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;

namespace FoodDiary.Model
{

    /// <summary>
    /// Class describing a dish
    /// </summary>
    class Dish : EnergyValueClass
    {
        int idDish;
        int maxCountDishes;
        string name;
        int countDishes;
        int energyValue;
        float maxCarbohydrate, maxProtein, maxFat;
        Dictionary<Ingredient, int> ingridientCount = new Dictionary<Ingredient, int>();

        public int IdDish
        {
            get { return idDish; }
        }
        /// <summary>
        /// Name of the dish
        /// </summary>
        public new string Name
        {
            get { return name; }
        }

        /// <summary>
        /// Energy value
        /// </summary>
        public new int EnergyValue
        {
            get
            {
                energyValue = EnergyValueMethodForDish();
                return energyValue;
            }
            set { energyValue = value; }

        }

        /// <summary>
        /// Quantity in grams dish
        /// </summary>
        public int CountDishes
        {
            get
            {
                return countDishes;
            }
            set
            {
                countDishes = value;
            }
        }
        /// <summary>
        /// Amount of carbohydrates in a dish
        /// </summary>
        public float MaxCarbohydrate
        {
            get
            {
                return maxCarbohydrate;
            }
        }
        /// <summary>
        /// Amount of proteins in a dish
        /// </summary>
        public float MaxProtein
        {
            get { return maxProtein; }
        }

        /// <summary>
        /// Amount of fat in a dish
        /// </summary>
        public float MaxFat
        {
            get { return maxFat; }
        }

        public Dish(int id, string name)
        {
            idDish = id;
            this.name = name;
        }

        /// <summary>
        /// The sum of total fats, proteins and carbohydrates in a dish
        /// </summary>
        /// <param name="ingredient"></param>
        void CountMax(Ingredient ingredient)
        {
            maxProtein += ingredient.Protein;
            maxFat += ingredient.Fat;
            maxCarbohydrate += ingredient.Carbohydrate;
        }
        /// <summary>
        /// add an ingredient to a dish
        /// </summary>
        /// <param name="ingredient"></param>
        /// <param name="count"></param>
        public void AddIngredient(Ingredient ingredient, int count)
        {
            maxCountDishes += count;
            ingridientCount.Add(ingredient, count);
            CountMax(ingredient);
        }

        /// <summary>
        /// find out the calorie content of a dish
        /// </summary>
        /// <returns></returns>
        int EnergyValueMethodForDish()
        {
            float c = EnergyValueMethod(maxProtein, maxFat, maxCarbohydrate);
            float  temp = c / (float)maxCountDishes;
            energyValue =  (int)(temp * 100);
            return energyValue;
        } 
    }
}
