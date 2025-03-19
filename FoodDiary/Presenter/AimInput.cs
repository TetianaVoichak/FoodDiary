using System;
using System.Collections.Generic;
using System.Text;
using FoodDiary.Model;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace FoodDiary.Presenter
{
    //class describing the user's goal
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

       
        public int ProteinPercent
        {
            get { return aim.ProteinPercent; }
            
        }
        

        public int FatPercent
        {
            get { return aim.FatPercent; }
        }
        

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
        /// Serialization in xml of the Aim class
        /// </summary>
        void AimSerializer()
        {
            FileStream stream = new FileStream("Aim.xml", FileMode.Create, FileAccess.Write, FileShare.Read);
            // We save the object in an XML file on disk (SERIALIZATION)
            serializer.Serialize(stream, aim);
            stream.Close();
        }
        /// <summary>
        /// Deserialization of the Aim class
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
