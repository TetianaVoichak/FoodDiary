using System;
using System.Collections.Generic;

namespace FoodDiary
{
    //Presents a daily menu with restrictions on calories and macronutrients.
    public partial class TableDaysMenu
    {
        public int IdDate { get; set; }
        public int? MaxCalories { get; set; }
        public int? MaxProtein { get; set; }
        public int? MaxFat { get; set; }
        public int? MaxCarb { get; set; }
        public DateTime? DateDay { get; set; }
        public int? IdRepastes { get; set; }
    }
}
