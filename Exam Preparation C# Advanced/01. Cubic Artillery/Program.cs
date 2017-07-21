using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Cubic_Artillery
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxCapacity = int.Parse(Console.ReadLine());

            var bunkers = new Queue<string>();
            var weapans = new Queue<int>();
            var leftCapacity = maxCapacity;

            string line;
            while ((line = Console.ReadLine()) != "Bunker Revision")
            {
                var tokens = line.Split(' ');
                foreach (var element in tokens)
                {
                    int weapan;
                    var isDigit = int.TryParse(element, out weapan);
                    if (!isDigit)
                    {
                        bunkers.Enqueue(element);
                    }
                    else
                    {
                        var isSaved = false;
                        while (bunkers.Count > 1)
                        {
                            if (leftCapacity >= weapan)
                            {
                                weapans.Enqueue(weapan);
                                leftCapacity -= weapan;
                                isSaved = true;
                                break;
                            }

                            if (weapans.Count == 0)
                            {
                                Console.WriteLine($"{bunkers.Dequeue()} -> Empty");
                            }
                            else
                            {
                                Console.WriteLine($"{bunkers.Dequeue()} -> {string.Join(", ",weapans)}");
                            }
                            weapans.Clear();
                            leftCapacity = maxCapacity;

                        }

                        if (!isSaved)
                        {
                            if (weapan <= maxCapacity)
                            {
                                while (leftCapacity < weapan)
                                {
                                    leftCapacity += weapans.Dequeue();
                                }

                                weapans.Enqueue(weapan);
                                leftCapacity -= weapan;
                            }
                        }
                    }
                }
            }
        }
    }
}
