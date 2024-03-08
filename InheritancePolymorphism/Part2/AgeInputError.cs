using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    internal class AgeInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to enter an invalid age. This fired an error!";
        }
    }
}
