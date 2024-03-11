using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    internal class Horse : Animal
    {
        public string tailColor {  get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Neigh");
        }

        public override string Stats()
        {
            string allPropertiesAsText = base.Stats();

            allPropertiesAsText += $"\nTail color: {tailColor}";

            return allPropertiesAsText;
        }
    }
}
