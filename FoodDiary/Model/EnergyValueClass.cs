using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDiary.Model
{
    /// <summary>
    /// Class for calculating energy value
    /// </summary>
    public abstract class EnergyValueClass
    {
        string name;
        float protein;
        float fat;
        float carbohydrate;
        float energyValue;

        /// <summary>
        /// The name of the ingredient or dish for which the energy value is calculated
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// proteins  
        /// </summary>
        public float Protein
        {
            get { return protein; }
            set { protein = value; }
        }
        /// <summary>
        /// Fat
        /// </summary>
        public float Fat
        {
            get { return fat; }
            set { fat = value; }
        }
        /// <summary>
        /// Carbohydrate
        /// </summary>
        public float Carbohydrate
        {
            get { return carbohydrate; }
            set { carbohydrate = value; }
        }

        /// <summary>
        /// energy value for the product
        /// </summary>
        public float EnergyValue
        {
            get
            {
                energyValue = carbohydrate * CountPFC.CAL_IN_ONE_CARB + protein * CountPFC.CAL_IN_ONE_PROTEIN + fat * CountPFC.CAL_IN_ONE_FAT;
                return energyValue;
            }
            set { energyValue = value; }
        }
        /// <summary>
        /// energy value for a product with input parameters
        /// </summary>
        /// <param name="protein"></param>
        /// <param name="fat"></param>
        /// <param name="carbohydrate"></param>
        /// <returns></returns>
        public float EnergyValueMethod(float protein, float fat, float carbohydrate)
        {
            return carbohydrate * CountPFC.CAL_IN_ONE_CARB + protein * CountPFC.CAL_IN_ONE_PROTEIN + fat * CountPFC.CAL_IN_ONE_FAT;
        }


    }
}
