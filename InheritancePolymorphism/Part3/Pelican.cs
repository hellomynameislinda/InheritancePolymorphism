﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    internal class Pelican : Bird
    {
        public double BeakLength { get; set; }

        public override string Stats()
        {
            string allPropertiesAsText = base.Stats();

            allPropertiesAsText += $"\nBeak Length: {BeakLength}";

            return allPropertiesAsText;
        }
    }
}
