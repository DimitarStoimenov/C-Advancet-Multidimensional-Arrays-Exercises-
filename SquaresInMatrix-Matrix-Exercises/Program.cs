using System;
using System.Linq;

namespace SquaresInMatrix_Matrix_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int rows = int.Parse(input.Split()[0]);
            int cols = int.Parse(input.Split()[1]);

            string[,] matrix = new string[rows, cols];
            int sum = 0;

            for (int r = 0; r < rows; r++)
            {
                string[] symbolsArray = Console.ReadLine().Split();
                for (int c = 0; c < cols; c++)
                {
                    matrix[r, c] = symbolsArray[c];
                }
            }
            for (int r = 0; r < rows - 1; r++)
            {
                for (int c = 0; c < cols - 1; c++)
                {
                    if (matrix[r,c] == matrix[r,c + 1] && 
                        matrix[r,c] == matrix[r+1,c] && 
                        matrix[r,c] == matrix[r+1,c+1])
                    {
                        sum++;
                    }
                }
            }
            Console.WriteLine(sum); 
        }
    }
}
