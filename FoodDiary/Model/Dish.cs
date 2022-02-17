using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;

namespace FoodDiary.Model
{
    
    /// <summary>
    /// Класс описывающий блюдо
    /// </summary>
    class Dish: EnergyValueClass
    {
        int idDish;
        int maxCountDishes;
        string name;
        int countDishes;
        int energyValue;
        double maxCarbohydrate, maxProtein, maxFat;
        Dictionary<Ingredient, int> ingridientCount = new Dictionary<Ingredient, int>();

        public int IdDish
        {
            get { return idDish; }
        }
        /// <summary>
        /// Название блюда
        /// </summary>
        public new string Name
        {
            get { return name; }
        }

        /// <summary>
        /// Энергетическая ценность
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
        /// Количество в граммах блюдо
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
        /// Количество углеводов в блюде
        /// </summary>
        public double MaxCarbohydrate
        {
            get
            {
                return maxCarbohydrate;
            }
        }
        /// <summary>
        /// Количество белков в блюде
        /// </summary>
        public double MaxProtein
        {
            get { return maxProtein; }
        }

        /// <summary>
        /// Количество жиров в блюде
        /// </summary>
        public double MaxFat
        {
            get { return maxFat; }
        }

        public Dish(int id, string name)
        {
            idDish = id;
            this.name = name;
        }
      
        /// <summary>
        /// Сумма общих жиров, белков и углеводов в блюде
        /// </summary>
        /// <param name="ingredient"></param>
        void CountMax(Ingredient ingredient)
        {
            maxProtein += ingredient.Protein;
            maxFat += ingredient.Fat;
            maxCarbohydrate += ingredient.Carbohydrate;
        }
        /// <summary>
        /// добавить ингредиент в блюдо
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
        /// узнать каллорийность блюда
        /// </summary>
        /// <returns></returns>
        int EnergyValueMethodForDish()
        {
            int c = EnergyValueMethod(maxProtein, maxFat, maxCarbohydrate);
            double  temp = c / (double)maxCountDishes;
            energyValue =  (int)(temp * 100);
            return energyValue;
        } 
    }
}
