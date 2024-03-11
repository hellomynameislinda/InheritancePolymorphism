using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    internal class Flamingo : Bird
    {
        public string ShadeOfPink { get; set; }

        public override string Stats()
        {
            string allPropertiesAsText = base.Stats();

            allPropertiesAsText += $"\nShade of Pink: {ShadeOfPink}";

            return allPropertiesAsText;
        }
    }
}
