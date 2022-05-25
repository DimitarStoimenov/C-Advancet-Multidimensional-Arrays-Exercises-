using System;
using System.Linq;

namespace MatrixShuffling__Matrix_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int rolls = int.Parse(input.Split()[0]);
            int calls = int.Parse(input.Split()[1]);
           
            string[,] matrix = new string[rolls, calls];
            FilMatrix(matrix, rolls, calls);
            

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] rawCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (rawCommand[0] == "swap" && rawCommand.Length == 5)
                {



                    if (!IsMatrixValid(matrix, rawCommand))

                    {
                        Console.WriteLine("Invalid input!");
                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        SwapMatrix(matrix, rawCommand);
                    }


                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    command = Console.ReadLine();
                    continue;
                }

                command = Console.ReadLine();
            }
        }

        private static void SwapMatrix(string[,] matrix, string[] rawCommand)
        {
            int row1 = int.Parse(rawCommand[1]);
            int col1 = int.Parse(rawCommand[2]);
            int row2 = int.Parse(rawCommand[3]);
            int col2 = int.Parse(rawCommand[4]);

            string num1 = matrix[row1, col1];
            string num2 = matrix[row2, col2];
            matrix[row1, col1] = num2;
            matrix[row2, col2] = num1;

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r,c] + " ");

                }
                Console.WriteLine();
            }

        }

        private static void FilMatrix(string[,] matrix, int rolls, int calls)
        {
            for (int r = 0; r < rolls; r++)
            {
                string[] nums = Console.ReadLine()
                    .Split()
                   
                    .ToArray();
                for (int c = 0; c < calls; c++)
                {
                    matrix[r, c] = nums[c].ToString();
                }
            }
        }

        private static bool IsMatrixValid(string[,] matrix, string[] rawCommand)
        {  
            int row1 = int.Parse(rawCommand[1]);
            int col1 = int.Parse(rawCommand[2]);
            int row2 = int.Parse(rawCommand[3]);
            int col2 = int.Parse(rawCommand[4]);
           
            if (row1 >= 0 && row1 < matrix.GetLength(0) && col1 >= 0 && col1 <= matrix.GetLength(1) &&
                row2 >= 0 && row2 < matrix.GetLength(0) && col2 >= 0 && col2 <= matrix.GetLength(1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
