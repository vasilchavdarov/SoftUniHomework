using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetArmada
{
    class Program
               {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var activitiAndlegionName = new Dictionary<int, string>();
            var typeAndCount = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Trim().Split(new char[] { '=', '-', '>', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var activity = int.Parse(line[0]);
                var legionName = line[1];
                var soldierType = line[2];
                var count = int.Parse(line[3]);

                activitiAndlegionName.Add(activity, legionName);
                typeAndCount.Add(soldierType, count);

            }

            foreach (var item in activitiAndlegionName)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
            
        }
    }
}
