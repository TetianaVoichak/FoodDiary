using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDiary.Model
{
    /// <summary>
    /// Класс для подсчета энергетической ценности
    /// </summary>
    public abstract class EnergyValueClass : CountPFC
    {
        string name;
        float protein;
        float fat;
        float carbohydrate;
        float energyValue;

        /// <summary>
        /// Название ингредиента или блюда, для чего подсчитывается энергетическая ценность
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// Белки 
        /// </summary>
        public float Protein
        {
            get { return protein; }
            set { protein = value; }
        }
        /// <summary>
        /// Жиры
        /// </summary>
        public float Fat
        {
            get { return fat; }
            set { fat = value; }
        }
        /// <summary>
        /// Углеводы
        /// </summary>
        public float Carbohydrate
        {
            get { return carbohydrate; }
            set { carbohydrate = value; }
        }

        /// <summary>
        /// ????
        /// </summary>
        public float EnergyValue
        {
            get
            {
                energyValue = carbohydrate * CAL_IN_ONE_CARB + protein * CAL_IN_ONE_PROTEIN + fat * CAL_IN_ONE_FAT;
                return energyValue;
            }
            set { energyValue = value; }
        }
        /// <summary>
        /// ????
        /// </summary>
        /// <param name="protein"></param>
        /// <param name="fat"></param>
        /// <param name="carbohydrate"></param>
        /// <returns></returns>
        public float EnergyValueMethod(float protein, float fat, float carbohydrate)
        {
            return carbohydrate * CAL_IN_ONE_CARB + protein * CAL_IN_ONE_PROTEIN + fat * CAL_IN_ONE_FAT;
        }


    }
}
