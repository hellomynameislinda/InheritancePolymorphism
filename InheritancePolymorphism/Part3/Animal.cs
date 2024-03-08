using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    internal abstract class Animal
    {

        public string name { get; set; }
        public int age { get; set; }
        public double weight { get; set; }
        public string color { get; set; }
        public string habitat { get; set; }

        public abstract void DoSound();

        protected Animal(/*string name, int age, double weight, string color, string habitat*/)
        {
            /*
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.color = color;
            this.habitat = habitat;
            */
        }
    }
}
