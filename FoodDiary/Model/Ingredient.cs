using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDiary.Model
{
    //Класс описывающий ингредиент
    class Ingredient : EnergyValueClass
    {
        int idIngredient;
        public int IdIngredient
        {
            get { return idIngredient; }
        }
        public Ingredient(int id, string name, double protein, double fat, double carbohydrate)
        {
            idIngredient = id;
            Name = name;
            Protein = protein;
            Fat = fat;
            Carbohydrate = carbohydrate;
            EnergyValue = EnergyValueMethod(protein, fat, carbohydrate);

        }
        public Ingredient(int id,string name, double protein, double fat, double carbohydrate, int resultEnergy)
        {
            idIngredient = id;
            Name = name;
            Protein = protein;
            Fat = fat;
            Carbohydrate = carbohydrate;
            EnergyValue = resultEnergy;
        }

    }
}
