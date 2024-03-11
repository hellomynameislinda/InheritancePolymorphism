using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    internal class Swan : Bird
    {
        public double NeckLength { get; set; }

        public override string Stats()
        {
            string allPropertiesAsText = base.Stats();

            allPropertiesAsText += $"\nNeck Length: {NeckLength}";

            return allPropertiesAsText;
        }
    }
}
