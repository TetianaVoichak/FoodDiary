using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDiary.Model
{
    //Class describing the ingredient
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
    }
}
