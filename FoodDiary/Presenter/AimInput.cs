using System;
using System.Collections.Generic;
using System.Text;
using FoodDiary.Model;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace FoodDiary.Presenter
{
    
    class AimInput
    {
        Aim aim;

        readonly XmlSerializer serializer = new XmlSerializer(typeof(Aim));

        public int MaxCalories
        {
            get { return aim.MaxCalories; }
        }
        public int ProteinGram
        {
            get { return aim.ProteinGram; }
            
        }
        public int FatGram
        {
            get { return aim.FatGram; }

        }
        public int CarbohydrateGram
        {
            get { return aim.CarbohydrateGram; }
        }

        /// <summary>
        /// Процент белков 
        /// </summary>
        /// 
        public int ProteinPercent
        {
            get { return aim.ProteinPercent; }
            
        }
        /// <summary>
        /// Процент жиров
        /// </summary>

        public int FatPercent
        {
            get { return aim.FatPercent; }
        }
        /// <summary>
        /// Процент углеводов
        /// </summary>

        public int CarbohydratePercent
        {
            get { return aim.CarbohydratePercent; }
        }
        public AimInput()
        {
            aim = new Aim();
            AimDeserializer();
        }
        public AimInput(int cal, int persentProtein, int percentFat, int percentC)
        {
            aim = new Aim(cal, persentProtein, percentFat, percentC);
            AimSerializer();
            AimDeserializer();
        }
 

        /// <summary>
        /// Сериализация в xml класса Aim
        /// </summary>
        void AimSerializer()
        {
            FileStream stream = new FileStream("Aim.xml", FileMode.Create, FileAccess.Write, FileShare.Read);
            // Сохраняем объект в XML-файле на диске(СЕРИАЛИЗАЦИЯ).
            serializer.Serialize(stream, aim);
            stream.Close();
        }
        /// <summary>
        /// Десериализация класса Aim
        /// </summary>
        void AimDeserializer()
        {
            
            try
            {
                FileStream stream = new FileStream("Aim.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                aim = serializer.Deserialize(stream) as Aim;

            }
            catch
            {
                
            }       
        }

    }
}
