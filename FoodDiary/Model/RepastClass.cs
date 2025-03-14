using System;
using System.Collections.Generic;
using System.Text;


namespace FoodDiary.Model
{
    /// <summary>
    /// Класс описывающий блюда из конкретной трапезы
    /// </summary>
    class RepastClass : EnergyValueClass 
    {
        int idRepast; 
        public EnumRepast repast;
        public List<Ingredient> product ;
       
        public DateTime date;

        public int IdRepast
        {
            get { return idRepast; }
        }
        public DateTime Date
        {
            get { return date.Date; }
        }
       public EnumRepast Repast
       {
            get { return repast; }
       }

        public RepastClass(int id, DateTime date, EnumRepast repast, List<Ingredient> product)
        {
            idRepast = id;
            this.date = date;
            this.repast = repast;
            this.product = product;
        }
        public RepastClass(int id , DateTime date)
        {
            idRepast = id;
            this.date = date;
        }
        public RepastClass(EnumRepast @enum, DateTime date)
        {
            repast = @enum;
            this.date = date;
        }

    }
}
