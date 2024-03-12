using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    internal class Wolfman : Wolf, IPerson
    {
        public void Talk()
        {
            Console.WriteLine($"Hello I'm {Name}");
        }
    }
}
