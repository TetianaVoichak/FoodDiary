using System;
using System.Collections.Generic;
using System.Text;
using FoodDiary.Presenter;

namespace FoodDiary.Model
{
    /// <summary>
    /// A class DayCount describing one day of eating and calorie counting
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
        ///The current number of calories the user has burned
        /// </summary>
        public int CaloriesNow
        {
            get { return CountCalorNow(); }
        }
        /// <summary>
        /// Maximum recommended amount of calories
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
        /// Recommended daily protein intake
        /// </summary>
        public int ProteinGram
        {
            get
            {
                return aimInput.ProteinGram;
            }
        }
        /// <summary>
        /// Recommended daily fat intake
        /// </summary>
        public double FatGram
        {
            get
            {
                return aimInput.FatGram;
            }
        }
        /// <summary>
        /// Recommended daily carbohydrate intake
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
        /// Number of calories burned at the moment
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
