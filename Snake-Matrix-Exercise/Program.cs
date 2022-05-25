using System;
using System.Linq;

namespace Snake_Matrix_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string nums = Console.ReadLine();
            int rolls = int.Parse(nums.Split()[0]);
            int cows = int.Parse(nums.Split()[1]);
            int index = 0;
            char[,] matrix = new char[rolls, cows];

            string input = Console.ReadLine();
            

            
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                if (r % 2 == 0)
                {


                    for (int c = 0; c < matrix.GetLength(1); c++)
                    {
                        matrix[r, c] = input[index];
                        index++;
                        if (index >= input.Length)
                        {
                            index = 0;
                        }
                    }
                }
                else
                {
                    for (int c = cows -1 ; c >= 0; c--)
                    {
                        matrix[r, c] = input[index];
                        index++;
                        if (index >= input.Length)
                        {
                            index = 0;
                        }
                    }
                }
            }

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r,c]);
                }
                Console.WriteLine();
            }
        }
    }
}
