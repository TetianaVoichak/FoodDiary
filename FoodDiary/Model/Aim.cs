using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace FoodDiary.Model
{
    /// <summary>
    ///The class describes a goal set by the user. 
    ///The goal includes how many calories per day can be consumed,
    ///the amount of proteins, fats and carbohydrates.
    /// </summary>
    [Serializable]
    public class Aim
    {

        private int maxCalories;

        private int proteinPercent;

        private int fatPercent;

        private int carbohydratePercent;


        /// <summary>
        /// Maximum recommended number of calories per day set by the user
        /// </summary>
        [XmlElement]
        public int MaxCalories
        {
            get
            {
                return maxCalories;
            }
            set
            {
                maxCalories = value;
            }
        }
        /// <summary>
        ///Percentage of proteins
        /// </summary>
        /// 
        [XmlElement]
        public int ProteinPercent
        {
            get { return proteinPercent; }
            set { proteinPercent = value; }
        }
        /// <summary>
        /// Fat percentage
        /// </summary>
        [XmlElement]
        public int FatPercent
        {
            get { return fatPercent; }
            set { fatPercent = value; }
        }
        /// <summary>
        /// Carbohydrate percentage
        /// </summary>
        [XmlElement]
        public int CarbohydratePercent
        {
            get { return carbohydratePercent; }
            set { carbohydratePercent = value; }
        }
        /// <summary>
        ///Amount of proteins in grams for PFC (Proteins, Fats, Carbohydrates)
        /// </summary>
        [XmlIgnore]
        public int ProteinGram
        {
            get { return CountPFC.FormulaCountProteinInGram(maxCalories, proteinPercent); }
        }
        /// <summary>
        /// Amount of fat in grams for PFC (Proteins, Fats, Carbohydrates)
        /// </summary>
        [XmlIgnore]
        public int FatGram
        {
            get { return CountPFC.FormulaCountFatInGram(maxCalories, fatPercent); }
        }
        /// <summary>
        /// Amount of carbohydrates in grams for PFC (Proteins, Fats, Carbohydrates)
        /// </summary>
        [XmlIgnore]
        public int CarbohydrateGram
        {
            get { return CountPFC.FormulaCountCarboInGram(maxCalories, carbohydratePercent); }
        }

        public Aim()
        {

        }
        /// <summary>
        ///In total, proteins, fats and carbohydrates are no more than 100%, otherwise the recommended values ​​are set
        /// </summary>
        /// <param name="maxCalories">maximum recommended daily calorie intake</param>
        /// <param name="proteinPercent">Percentage of proteins</param>
        /// <param name="fatPercent">Fat percentage</param>
        /// <param name="carbohydratePercent">Percentage of carbohydrates</param>
        public Aim(int maxCalories, int proteinPercent, int fatPercent, int carbohydratePercent)
        {
            if (maxCalories < 0 || maxCalories > 20000)
            {
                throw new Exception("The value in the calorie field is too high!");
            }
            else
            {
                this.maxCalories = maxCalories;
            }
            if ((proteinPercent + fatPercent + carbohydratePercent) <= 100 && proteinPercent > 0 && fatPercent > 0 && carbohydratePercent > 0)
            {
                this.proteinPercent = proteinPercent;
                this.fatPercent = fatPercent;
                this.carbohydratePercent = carbohydratePercent;
            }
            else
            {
                throw new Exception("Inadmissible values ​​for PFC! The total should not be more than 100%!");
            }
        }

    }
}
