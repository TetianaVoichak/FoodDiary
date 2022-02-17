using System;
using System.Collections.Generic;
using System.Text;
using FoodDiary.Presenter;

namespace FoodDiary.Model
{
    /// <summary>
    /// Класс описывающий один день приема пищи и подсчета каллорий
    /// </summary>
    class DayCount : EnergyValueClass
    {
        int idDayCount;
        AimInput aimInput;
        DateTime date;
        int caloriesMax;
        int caloriesNow;
        List<RepastClass> repastes = new List<RepastClass>();

        public int IdDayCount
        {
            get { return idDayCount; }
        }
        
        /// <summary>
        ///Текущее число каллорий, которое потратил пользователь
        /// </summary>
        public int CaloriesNow
        {
            get { return CountCalorNow(); }
        }
        /// <summary>
        /// Максимально рекомендуемое количество каллорий
        /// </summary>
        public int CaloriesMax
        {
            get 
            { 
                caloriesMax = aimInput.MaxCalories;
                return caloriesMax;
            }
        }

       

        /// <summary>
        /// Количество белков рекоменудемое в день
        /// </summary>
        public int ProteinGram
        {
            get
            {
                return aimInput.ProteinGram;
            }
        }
        /// <summary>
        /// Количество жиров рекомендуемое в день
        /// </summary>
        public double FatGram
        {
            get
            {
                return aimInput.FatGram;
            }
        }
        /// <summary>
        /// Количество углеводов рекомендуемое в день
        /// </summary>
        public double CarbohydrateGram
        {
            get { return aimInput.CarbohydrateGram; }
        }


     /// <summary>
     /// 
     /// </summary>
     /// <param name="protein"></param>
     /// <param name="fat"></param>
     /// <param name="carbohydrate"></param>
        public DayCount()
        {
            aimInput = new AimInput();
            date = DateTime.Now;
            Protein = aimInput.ProteinGram;
            Fat = aimInput.FatGram;
            Carbohydrate = aimInput.CarbohydrateGram;
            caloriesMax = aimInput.MaxCalories;
            repastes.Add(new RepastClass(1,date));   
        }
        public DayCount(EnumRepast repast)
        {

        }

        public DayCount(DateTime date)
        {
            aimInput = new AimInput();
            this.date = date;
            Protein = aimInput.ProteinGram;
            Fat = aimInput.FatGram;
            Carbohydrate = aimInput.CarbohydrateGram;
            caloriesMax = aimInput.MaxCalories;
            repastes.Add(new RepastClass(1,date));
        }
        public void AddRepast(RepastClass repast)
        {
            repastes.Add(repast);
        }
        /// <summary>
        /// Число потраченных каллорий на текущий момент
        /// </summary>
        /// <returns></returns>
        int CountCalorNow()
        {
           foreach(EnergyValueClass item in repastes)
           {
                item.EnergyValueMethod(item.Protein, item.Fat, item.Carbohydrate);
           }
            return caloriesNow;
        }

    }

}
