﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InheritancePolymorphism
{
    internal class PersonHandler
    {
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person p = new Person();
            SetAge(p, age);
            SetFName(p, fname);
            SetLName(p, lname);
            SetHeight(p, height);
            SetWeight(p, weight);
            return p;
        }

        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
        public void SetFName(Person pers, string fName)
        {
            pers.FName = fName;
        }
        public void SetLName(Person pers, string lName)
        {
            pers.LName = lName;
        }
        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }
        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }
    }
}
