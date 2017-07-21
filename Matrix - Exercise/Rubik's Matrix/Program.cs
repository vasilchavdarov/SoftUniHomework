using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubik_s_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var rotation = int.Parse(Console.ReadLine());
            int[][] matrix = new int[matrixSize[0]][];

            var cellsCount = 1;
            
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new int[matrixSize[1]];
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = cellsCount;
                    cellsCount++;
                }
            }

            for (int i = 0; i < rotation; i++)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var rowCol = int.Parse(input[0]);
                var direction = input[1];
                var moves = int.Parse(input[2]);
                var countMoves = 0;

                if (direction == "down" || direction == "up")
                {
                    while (moves != countMoves)
                    {
                        if (direction == "up")
                        {
                            for (int row = 0; row < matrix.Length - 1; row++)
                            {
                                for (int col = 0; col < matrix[row].Length; col++)
                                {
                                    if (rowCol == col)
                                    {
                                        var temp = matrix[row][col];
                                        matrix[row][col] = matrix[row + 1][col];
                                        matrix[row + 1][col] = temp;
                                    }
                                }
                            }
                        }
                        else //(direction == "down")
                        {
                            for (int row = matrix.Length - 1; row > 0; row--)
                            {
                                for (int col = 0; col < matrix[row].Length; col++)
                                {
                                    if (rowCol == col)
                                    {
                                        var temp = matrix[row][col];
                                        matrix[row][col] = matrix[row - 1][col];
                                        matrix[row - 1][col] = temp;
                                    }
                                }
                            }
                        }
                        
                        countMoves++;
                    }
                }
                else //(direction == left or right)
                {   
                    RotationLeftRight(matrix, direction, moves, rowCol);
                }
                
            }

            var cellConteins = 1;
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (cellConteins == matrix[row][col])
                    {
                        Console.WriteLine("No swap required");
                        cellConteins++;
                    }
                    else
                    {
                        int[] coordinates = searchElement(matrix, cellConteins);
                        Console.WriteLine($"Swap ({row}, {col}) with ({coordinates[0]}, {coordinates[1]})");
                        int temp = matrix[row][col];
                        matrix[row][col] = matrix[coordinates[0]][coordinates[1]];
                        matrix[coordinates[0]][coordinates[1]] = temp;
                        cellConteins++;
                    }
                }
            }
        }
        private static int[] searchElement(int[][] matrix, int value)
        {
            int[] coordinates = new int[2];
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == value)
                    {
                        coordinates[0] = i;
                        coordinates[1] = j;
                        return coordinates;
                    }
                }
            }
            return new int[] { -1, -1 };
        }

        private static void RotationLeftRight(int[][] matrix, string direction, int moves, int rowCol)
        {
            var countMoves = 0;
            for (int row = 0; row < matrix.Length; row++)
            {
                if (rowCol == row)
                {
                    if (direction == "left")
                    {
                        while (moves != countMoves)
                        {
                            for (int col = 0; col < matrix[row].Length - 1; col++)
                            {
                                var temp = matrix[row][col];
                                matrix[row][col] = matrix[row][col + 1];
                                matrix[row][col + 1] = temp;
                            }
                            countMoves++;
                        }
                    }
                    else //(direction == "right")
                    {
                        while (moves != countMoves)
                        {
                            for (int col = matrix[row].Length - 1; col > 0; col--)
                            {
                                var temp = matrix[row][col];
                                matrix[row][col] = matrix[row][col - 1];
                                matrix[row][col - 1] = temp;
                            }
                            countMoves++;
                        }

                    }
                }
            }
        }
    }
}
