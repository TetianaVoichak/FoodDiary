using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDiary
{
    class EnergyValueClass
    {
        public int carbohydrate,  protein,  fat;
        public EnergyValueClass(int protein, int fat, int carbohydrate)
        {
            this.protein = protein;
            this.fat = fat;
            this.carbohydrate = carbohydrate;
        }
        public EnergyValueClass()
        {

        }
        public int EnergyValue
        {
            get { return EnergyValueCount(); }
        }

        int EnergyValueCount()
        {
            return carbohydrate * 4 + protein * 4 + fat * 9;
        }
    }
}
