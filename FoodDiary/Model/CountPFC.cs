using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace FoodDiary.Model
{
    /// <summary>
    /// Класс для подсчета БЖУ
    /// </summary>
   
    public abstract class CountPFC  
    {
        [NonSerialized]
        public const int CAL_IN_ONE_FAT = 9;
        [NonSerialized]
        public const int CAL_IN_ONE_PROTEIN = 4;
        [NonSerialized]
        public const int CAL_IN_ONE_CARB = 4;
        [NonSerialized]
        public const int PERCENT = 100;

        /// <summary>
        /// Формула подсчета бжу (белки)
        /// </summary>
        /// <returns></returns>
        public int FormulaCountProteinInGram(int calories, int percent)
        {
            double temp = calories * ((double)percent / PERCENT) / CAL_IN_ONE_PROTEIN;
            return (int)(calories * ((double)percent / PERCENT) / CAL_IN_ONE_PROTEIN);
        }

        /// <summary>
        /// Формула подсчета бжу (жиры)
        /// </summary>
        /// <returns></returns>
        public int FormulaCountFatInGram(int calories, int percent)
        {
            return (int)(calories * ((double)percent / PERCENT) / CAL_IN_ONE_FAT);
        }

        /// <summary>
        /// Формула подсчета бжу (углеводы)
        /// </summary>
        /// <returns></returns>
        public int FormulaCountCarboInGram(int calories, int percent)
        {
            return (int)(calories * ((double)percent / PERCENT) / CAL_IN_ONE_CARB);
        }



    }
}
