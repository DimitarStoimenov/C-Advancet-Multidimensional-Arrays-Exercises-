using System;
using System.Linq;

namespace JaggedArrayManipulator_Matrix_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[][] matrix = new int[num][].ToArray();

            for (
                int r = 0; r < num; r++)
            {


                matrix[r] = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();



            }

            for (int ro = 0; ro < matrix.GetLength(0) - 1; ro++)
            {
                if (matrix[ro].Length == matrix[ro + 1].Length)
                {
                    matrix[ro] = matrix[ro].Select(el => el * 2).ToArray();
                    matrix[ro + 1] = matrix[ro + 1].Select(el => el * 2).ToArray();
                }
                else
                {
                    matrix[ro] = matrix[ro].Select(el => el / 2).ToArray();
                    matrix[ro + 1] = matrix[ro + 1].Select(el => el / 2).ToArray();
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                int row = int.Parse(command.Split()[1]);
                int col = int.Parse(command.Split()[2]);
                int val = int.Parse(command.Split()[3]);


                if (command.StartsWith("Add"))
                {
                    

                    if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(row))
                    {
                        matrix[row][col] += val;
                    }
                }
                else if (command.StartsWith("Subtract"))
                {
                    
                    if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(row))
                    {
                        matrix[row][col] -= val;
                    }
                }

                command = Console.ReadLine();
            }
            for (int r = 0; r < num; r++)

            {
                for (int c = 0; c < matrix[r].Length; c++)
                {


                    Console.Write(matrix[r][c] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
