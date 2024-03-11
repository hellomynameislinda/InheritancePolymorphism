using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    internal abstract class Animal
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }
        public string Habitat { get; set; }

        public abstract void DoSound();


        protected Animal(/*string name, int age, double weight, string color, string habitat*/)
        {
            /*
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
            this.Color = color;
            this.Habitat = habitat;
            */
        }

        public virtual string Stats()
        {
            string allPropertiesAsText = string.Empty;

            allPropertiesAsText = $"Name: {Name}\nAge: {Age}\nWeight: {Weight}\nColor: {Color}\nHabitat {Habitat}";

            /*
            // Keeping this only for future reference
            string allPropertiesAsText = "Properties and values of this object:";
            var allPropertiesList = this.GetType().GetProperties();

            foreach (var property in allPropertiesList)
            {
                allPropertiesAsText += ($"\n{property.Name}: {property.GetValue(this)}");
            }
            */

            return allPropertiesAsText;
        }
    }

    internal interface IPerson
    {
        void Talk();
    }
}
