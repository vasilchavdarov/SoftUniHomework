using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leydy_Bugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var LadybugIndexex = Console.ReadLine().Split(' ').Select(int.Parse).Where(a => a >= 0 && a < size).ToArray();

            var ladybugs = new int[size];

            for (int i = 0; i < LadybugIndexex.Length; i++)
            {
                var currentLadyBugIndex = LadybugIndexex[i];
                ladybugs[currentLadyBugIndex] = 1;
            }

            var line = Console.ReadLine();

            while (line != "end")
            {
                var tokens = line.Split();

                var ladyBugIndex = int.Parse(tokens[0]);
                var direction = tokens[1];
                var flyLenght = int.Parse(tokens[2]);

                if (ladyBugIndex < 0 || ladyBugIndex >= ladybugs.Length)
                {
                    line = Console.ReadLine();
                    continue;
                }

                if (ladybugs[ladyBugIndex] == 0)
                {
                    line = Console.ReadLine();
                    continue;
                }

                MoveLadybug(ladybugs, ladyBugIndex, flyLenght,direction);

                line = Console.ReadLine();

            }

            Console.WriteLine(string.Join(" ",ladybugs));

        }

        static void MoveLadybug(int[] ladybugs, int ladyBugIndex, int flyLenght, string direction)
        {
            ladybugs[ladyBugIndex] = 0;

            var leftArrayOrFindPlace = false;
            while (!leftArrayOrFindPlace)
            {
                switch (direction)
                {
                    case "left":
                        ladyBugIndex -= flyLenght;
                        break;
                    case "right":
                        ladyBugIndex += flyLenght;
                        break;
                }

                if (ladyBugIndex < 0 || ladyBugIndex >= ladybugs.Length)
                {
                    leftArrayOrFindPlace = true;
                    continue;
                }

                if (ladybugs[ladyBugIndex] == 1)
                {
                    continue;
                }

                if (ladybugs[ladyBugIndex] == 0)
                {
                    ladybugs[ladyBugIndex] = 1;
                    leftArrayOrFindPlace = true;
                    continue;

                }
            }
        }
    }
}
