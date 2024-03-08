using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    internal class DateInputError : UserError
    {
        public override string UEMessage()
        {
            return "You did not enter a valid format date. This fired an error!";
        }
    }
}
