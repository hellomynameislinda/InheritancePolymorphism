using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    internal class Bird : Animal
    {
        public double WingSpan { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Chirp");
        }
    }
}
