using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using FoodDiary.Model;
using FoodDiary.Presenter;

namespace FoodDiary
{
    public /*partial*/ class IngredientDB
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float? Protein { get; set; }
        public float? Fat { get; set; }
        public float? Carbohydrate { get; set; }
        public float? EnergyValue { get; set; }



    }
}
