using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = int.Parse(Console.ReadLine());
            int[][] matrix = new int[matrixSize][];

            for (int row = 0; row < matrixSize; row++)
            {
                matrix[row] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }
            var fitstDiagonalSum = 0;
            var secondDiagonalSum = 0;
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (row == col)
                    {
                        fitstDiagonalSum += matrix[row][col];
                    }
                    
                }
            }

            var counter = 1;
            foreach (int[] row in matrix)
            {
                
                secondDiagonalSum += row[matrixSize - counter];
                counter++;
            }

            Console.WriteLine(Math.Abs(fitstDiagonalSum - secondDiagonalSum));

        }
    }
}
