using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    internal class Hedgehog : Animal
    {
        public int NumberOfSpikes { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Grunt");
        }

        public override string Stats()
        {
            string allPropertiesAsText = base.Stats();

            allPropertiesAsText += $"\nNumber of Spikes: {NumberOfSpikes}";

            return allPropertiesAsText;
        }
    }
}
