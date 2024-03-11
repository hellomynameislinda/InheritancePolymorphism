using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    internal class Wolf : Animal
    {
        public int flockSize {  get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Howl");
        }

        public override string Stats()
        {
            string allPropertiesAsText = base.Stats();

            allPropertiesAsText += $"\nFlock size: {flockSize}";

            return allPropertiesAsText;
        }
    }
}
