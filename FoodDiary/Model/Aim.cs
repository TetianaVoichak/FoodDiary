using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace FoodDiary.Model
{
    /// <summary>
    /// Класс описывает цель установливаемую пользователем
    /// </summary>
    [Serializable]
    public class Aim : CountPFC
    {
       
        private int maxCalories; 
      
        private int proteinPercent;
      
        private int fatPercent;
      
        private int carbohydratePercent;


        /// <summary>
        /// Максимально рекомендуемое число каллорий в день заданное пользователем
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
        /// Процент белков 
        /// </summary>
        /// 
        [XmlElement]
        public int ProteinPercent
        {
            get { return proteinPercent; }
            set { proteinPercent = value; }
        }
        /// <summary>
        /// Процент жиров
        /// </summary>
        [XmlElement]
        public int FatPercent
        {
            get { return fatPercent; }
            set { fatPercent = value; }
        }
        /// <summary>
        /// Процент углеводов
        /// </summary>
        [XmlElement]
        public int CarbohydratePercent
        {
            get { return carbohydratePercent; }
            set { carbohydratePercent = value; }
        }
        /// <summary>
        /// Количество белков в граммах для БЖУ
        /// </summary>
        [XmlIgnore]
        public int ProteinGram
        {
            get { return FormulaCountProteinInGram(maxCalories, proteinPercent); }
            //set { maxCalories = value; }
        }
        /// <summary>
        /// Количество жиров в граммах для БЖУ 
        /// </summary>
        [XmlIgnore]
        public int FatGram
        {
            get { return FormulaCountFatInGram(maxCalories,fatPercent); }
            //set { fatPercent = value; }
        }
        /// <summary>
        /// Количество углеводов в граммах для БЖУ 
        /// </summary>
        [XmlIgnore]
        public int CarbohydrateGram
        {
            get { return FormulaCountCarboInGram(maxCalories,carbohydratePercent); }
            //set { carbohydratePercent = value; }
        }
        
        public Aim()
        {

        }
        /// <summary>
        /// В сумме белки,жиры и углеводы не больше 100%, иначе выставляются рекомендуемые значения
        /// </summary>
        /// <param name="maxCalories">максимально рекомендуемое число каллорий в день</param>
        /// <param name="proteinPercent">Процент белков</param>
        /// <param name="fatPercent">Процент жиров</param>
        /// <param name="carbohydratePercent">Процент углеводов</param>
        public Aim( int maxCalories, int proteinPercent,int fatPercent, int carbohydratePercent)
        {
            if(maxCalories < 0 || maxCalories > 20000)
            {
                throw new Exception("Слишком большое значение в поле каллорийность!");
            }
            else
            {
                this.maxCalories = maxCalories;
            }
            if((proteinPercent + fatPercent + carbohydratePercent) <= 100 && proteinPercent > 0 && fatPercent > 0 && carbohydratePercent > 0 )
            {
                this.proteinPercent = proteinPercent;
                this.fatPercent = fatPercent;
                this.carbohydratePercent = carbohydratePercent;
            }
            else
            {
                //this.proteinPercent = 20;
                //this.fatPercent = 30;
                //this.carbohydratePercent = 50;
                throw new Exception("Не допустимые значения для БЖУ! В сумме должно быть не больше 100%!");
            }
        }


       

    }
}
