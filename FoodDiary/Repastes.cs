using System;
using System.Collections.Generic;

namespace FoodDiary
{
    //presents a set of products with weights for each meal
    public partial class Repastes
    {
        public int IdRepastes { get; set; }
        public int? IdRepastType { get; set; }
        public int? IdProduct { get; set; }
        public int? Weight { get; set; }

       
    }
}
