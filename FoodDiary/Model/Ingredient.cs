using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDiary.Model
{
    //Класс описывающий ингредиент
    public class Ingredient : EnergyValueClass
    {
        int idIngredient;
        public int IdIngredient
        {
            get { return idIngredient; }
            set { idIngredient = value; }
        }
        public Ingredient()
        { 
        }
        public Ingredient(int id, string name, float protein, float fat, float carbohydrate)
        {
            idIngredient = id;
            Name = name;
            Protein = protein;
            Fat = fat;
            Carbohydrate = carbohydrate;
            EnergyValue = EnergyValueMethod(protein, fat, carbohydrate);

        }
        //public Ingredient(int id, string name, double protein, double fat, double carbohydrate, double resultEnergy)
        //{
        //    idIngredient = id;
        //    Name = name;
        //    Protein = protein;
        //    Fat = fat;
        //    Carbohydrate = carbohydrate;
        //    EnergyValue = resultEnergy;
        //}

    }
}
