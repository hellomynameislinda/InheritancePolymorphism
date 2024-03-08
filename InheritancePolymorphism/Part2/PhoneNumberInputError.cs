using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    internal class PhoneNumberInputError : UserError
    {
        public override string UEMessage()
        {
            return "You did not enter a valid format phone number. This fired an error!";
        }
    }
}
