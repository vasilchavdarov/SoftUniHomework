using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixsize = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[][] matrix = new char[matrixsize[0]][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
            }

            var counter = 0;
            for (int row = 0; row < matrix.Length - 1; row++)
            {
                for (int col = 0; col < matrix[row].Length - 1; col++)
                {
                    var currentChar = matrix[row][col];
                    if (currentChar == matrix[row][col + 1] && currentChar == matrix[row + 1][col] && currentChar == matrix[row + 1][col + 1])
                    {
                        counter++;
                    }
                }
            }

            
            Console.WriteLine(counter);
            
        }
    }
}
