using System;
using System.Linq;

namespace MaximalSum_Matrix_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int rows = int.Parse(input.Split()[0]);
            int cols = int.Parse(input.Split()[1]);
            int[,] matrix = new int[rows, cols];
            int maxSum = int.MinValue;
            int curr = 0;
            int bestR = 0;
            int bestC = 0;

            for (int r = 0; r < rows; r++)
            {
                int[] symbolsArray = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int c = 0; c < cols; c++)
                {
                    matrix[r, c] = symbolsArray[c];
                }
            }
            for (int r = 0; r < rows - 2; r++)
            {
                for (int c = 0; c < cols - 2; c++)
                {
                    curr = matrix[r, c] + matrix[r, c + 1] + matrix[r, c + 2] +
                       matrix[r + 1, c] + matrix[r + 1, c + 1] + matrix[r + 1, c + 2] +
                       matrix[r + 2, c] + matrix[r + 2, c + 1] + matrix[r + 2, c + 2];

                    if (curr > maxSum)
                    {
                        maxSum = curr;

                        bestR = r;
                        bestC = c;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            for (int r = bestR; r < bestR + 3; r++)
            {

                for (int c = bestC; c < bestC + 3; c++)
                {
                    Console.Write(matrix[r, c] + " ");
                 }

                Console.WriteLine();
            }
        }
    }
}
