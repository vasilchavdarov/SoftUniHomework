using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int starNumb = int.Parse(Console.ReadLine());
            int endNumb = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(", ", FindPrimeInRange(starNumb, endNumb)));
        }

        public static List<int> FindPrimeInRange( int startNumb, int endNumb)
        {
            var primeNumbs = new List<int>();

            for (int i = startNumb; i <= endNumb; i++)
            {
                if (Primechekur(i))
                {
                    primeNumbs.Add(i);
                }
            }

            return primeNumbs;
        }

        private static bool Primechekur(long n)
        {
            var isPrime = true;

            if (n == 1 || n == 0)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                }
            }

            return isPrime;
        }
    }
}
