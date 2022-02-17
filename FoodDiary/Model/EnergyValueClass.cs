using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDiary.Model
{
    /// <summary>
    /// Класс для подсчета энергетической ценности
    /// </summary>
    abstract class EnergyValueClass : CountPFC
    {
        string name;
        double protein;
        double fat;
        double carbohydrate;
        int energyValue;

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
        public double Protein
        {
            get { return protein; }
            set { protein = value; }
        }
        /// <summary>
        /// Жиры
        /// </summary>
        public double Fat
        {
            get { return fat; }
            set { fat = value; }
        }
        /// <summary>
        /// Углеводы
        /// </summary>
        public double Carbohydrate
        {
            get { return carbohydrate; }
            set { carbohydrate = value; }
        }

        /// <summary>
        /// ????
        /// </summary>
        public int EnergyValue
        {
            get
            {
                energyValue = (int)(carbohydrate * CAL_IN_ONE_CARB + protein * CAL_IN_ONE_PROTEIN + fat * CAL_IN_ONE_FAT);
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
        public int EnergyValueMethod(double protein, double fat, double carbohydrate)
        {
            return (int)(carbohydrate * CAL_IN_ONE_CARB + protein * CAL_IN_ONE_PROTEIN + fat * CAL_IN_ONE_FAT);
        }


    }
}
