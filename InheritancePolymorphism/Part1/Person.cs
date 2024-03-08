using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InheritancePolymorphism
{
    internal class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {

                if (value <= 0)
                {
                    throw new ArgumentException("Age must be above 0.");
                }
                else
                {
                    age = value;
                }

            }
        }

        public string FName
        {
            get
            {
                return fName;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("First name can not be null or empty.");
                }
                else
                {
                    if (value.Length < 2 || value.Length > 10)
                    {
                        throw new ArgumentException("Firt name must be between 2 and 10 characters.");
                    }
                    else
                    {
                        fName = value;
                    }

                }
            }
        }

        public string LName
        {
            get
            {
                return lName;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Last name can not be null or empty.");
                }
                else
                {
                    if (value.Length < 3 || value.Length > 15)
                    {
                        throw new ArgumentException("Last name must be between 2 and 10 characters.");
                    }
                    else
                    {
                        lName = value;
                    }

                }
            }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}
