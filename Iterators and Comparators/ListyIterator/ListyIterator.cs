using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private IList<T> list;
        private int currentIndex = 0;

        public ListyIterator()
        {
            this.list = new List<T>();
        }

        public void Add(T element)
        {
            list.Add(element);
        }

        public bool Move()
        {
            if ((currentIndex + 1) < this.list.Count)
            {
                return this.currentIndex++ < this.list.Count;
            }
            else
            {
                return false;
            }
        }

        public void Print()
        {
            if (currentIndex < list.Count)
            {
                Console.WriteLine(list[currentIndex]);
            }
            else
            {
                Console.WriteLine("Invalid Operation!");
            }
        }

        public void PrintAll()
        {
            Console.WriteLine(string.Join(" ",list));
        }

        public bool HasNext()
        {
            if ((currentIndex + 1) < this.list.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < list.Count; i++)
            {
                yield return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
