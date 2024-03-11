using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    internal class Dog : Animal
    {
        public string Pattern { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Bark");
        }

        public override string Stats()
        {
            string allPropertiesAsText = base.Stats();

            allPropertiesAsText += $"\nPattern: {Pattern}";

            return allPropertiesAsText;
        }

        public string PetName()
        {
            return "Pet name: Vovven";
        }

    }
}
