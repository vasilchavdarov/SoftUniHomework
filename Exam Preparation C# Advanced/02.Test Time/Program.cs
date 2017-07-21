using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Nature_s_Prophet
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[][] matrix = new int[matrixSize[0]][];
            var r = new Dictionary<int, int>();

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new int[matrixSize[1]];
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = 0;
                }
            }

            var line = Console.ReadLine();

            while (line != "Bloom Bloom Plow")
            {
                var flowerIndex = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                var flowerRow = flowerIndex[0];
                var flowerCol = flowerIndex[1];

                r.Add(flowerRow, flowerCol);
                
                line = Console.ReadLine();
            }

            var l = r.OrderBy(key => key.Key);
            var dictionary = l.ToDictionary((keyItem) => keyItem.Key, (valueItem) => valueItem.Value);

            for (int row = 0; row < matrix.Length; row++)
            {
                foreach (var item in dictionary)
                {
                    if (row == item.Key)
                    {
                        for (int col = 0; col < matrix[row].Length; col++)
                        {
                            matrix[row][col]++;
                            if (col == item.Value)
                            {
                                for (int i = 0; i < matrix.Length; i++)
                                {
                                    matrix[i][col]++;
                                }
                            }
                        }
                    }
                    matrix[item.Key][item.Value]--;
                }
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write($"{matrix[row][col]} ");
                }
                Console.WriteLine();
            }
        }

    }
}
