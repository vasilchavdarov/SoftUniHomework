using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_of_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            string[][] matrix = new string[matrixSize[0]][];
            var alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };


            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new string[matrixSize[1]];
                for (int col = 0; col < matrixSize[1]; col++)
                {
                    var firstChar = alphabet[row];
                    var secondChar = alphabet[row + col];
                    var thirdChar = alphabet[row];
                    var stringadd = (firstChar.ToString() + secondChar.ToString() + thirdChar.ToString());
                    matrix[row][col] = stringadd;
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
