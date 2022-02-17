using System;
using System.Collections.Generic;

namespace FoodDiary
{
    public partial class IngredientDb
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float? Protein { get; set; }
        public float? Fat { get; set; }
        public float? Carbohydrate { get; set; }
        public float? EnergyValue { get; set; }
    }
}
