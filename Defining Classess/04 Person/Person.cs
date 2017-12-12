﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Person
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                age = value;
            }
        }


        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name's length should not be less than 3 symbols!");
                }
                name = value;
            }
        }

        public override string ToString()
        {
            return $"Name: { this.Name}, Age: { this.Age}";
        }

    }
}
