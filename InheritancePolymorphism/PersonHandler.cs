using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    internal class PersonHandler
    {
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {

            return new Person();
        }

        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

    }
}
