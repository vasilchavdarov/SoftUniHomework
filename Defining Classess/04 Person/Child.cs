using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Person
{
    public class Child : Person
    {
        private int age;

        public Child(string name, int age) : base(name, age)
        {
            this.Age = age;
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 15)
                {
                    throw new ArgumentException("Child's age must be less than 15!");
                }
                age = value;
            }
        }
    }
}
