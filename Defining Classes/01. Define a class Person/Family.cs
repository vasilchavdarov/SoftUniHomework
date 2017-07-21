using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Define_a_class_Person
{
    class Family
    {
        private List<Person> member;

        public Family()
        {
            this.member = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.member.Add(member);
        } 

        public Person GetGetOldestMember()
        {
            return member.OrderByDescending(p => p.Age).FirstOrDefault();
        }
    }
}
