using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    internal class Worm : Animal
    {
        public double length {  get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Pop");
        }

        public override string Stats()
        {
            string allPropertiesAsText = base.Stats();

            allPropertiesAsText += $"\nLength: {length}";

            return allPropertiesAsText;
        }
    }
}
