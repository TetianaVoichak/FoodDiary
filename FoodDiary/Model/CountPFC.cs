using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Xml.Serialization;

namespace FoodDiary.Model
{
    /// <summary>
    /// Class for calculating PFC (Proteins, Fats, Carbohydrates)
    /// </summary>

    public static class CountPFC  
    {
        //constant number for fats for calculation by formula
        public const int CAL_IN_ONE_FAT = 9;

        //constant number for protein for calculation by formula
        public const int CAL_IN_ONE_PROTEIN = 4;

        //constant number for carbohydrates for calculation by formula
        public const int CAL_IN_ONE_CARB = 4;

        //the percentage is always 100
        public const int PERCENT = 100;

        /// <summary>
        /// Formula for calculating PFC (proteins)
        /// </summary>
        /// <returns></returns>
        public static int FormulaCountProteinInGram(int calories, int percent)
        {
            double temp = calories * ((double)percent / PERCENT) / CAL_IN_ONE_PROTEIN;
            return (int)(calories * ((double)percent / PERCENT) / CAL_IN_ONE_PROTEIN);
        }

        /// <summary>
        /// Formula for calculating PFC (fats)
        /// </summary>
        /// <returns></returns>
        public static int FormulaCountFatInGram(int calories, int percent)
        {
            return (int)(calories * ((double)percent / PERCENT) / CAL_IN_ONE_FAT);
        }

        /// <summary>
        ///  Formula for calculating PFC (Carbohydrates)
        /// </summary>
        /// <returns></returns>
        public static int FormulaCountCarboInGram(int calories, int percent)
        {
            return (int)(calories * ((double)percent / PERCENT) / CAL_IN_ONE_CARB);
        }



    }
}
