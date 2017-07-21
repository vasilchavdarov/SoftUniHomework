using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _01.Define_a_class_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfPeople = int.Parse(Console.ReadLine());
            var people = new List<Person>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                var personInfo = Console.ReadLine().Split(' ');
                var personName = personInfo[0];
                var personAge = int.Parse(personInfo[1]);

                var person = new Person(personName, personAge);

                if (person.Age > 30)
                {
                    people.Add(person);
                }
            }
            
            foreach (var humen in people.OrderBy(p => p.Name))
            {
                Console.WriteLine($"{humen.Name} - {humen.Age}");
            }

        }

    }
}
