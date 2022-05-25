using System;
using System.Linq;

namespace PrimaryDiagonal_Matrix_Lab
    {
        class Program
        {
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                int[,] matrix = new int[n, n];
                int firstSum = 0;
                int secondSum = 0;

                for (int r = 0; r < n; r++)
                {
                    int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    for (int c = 0; c < nums.Length; c++)
                    {
                        matrix[r, c] = nums[c];
                        if (r == c)
                        {
                            firstSum += nums[c];
                        }
                        if (r + c == nums.Length - 1)
                        {
                            secondSum += nums[c];
                        }
                    }

                }

                Console.WriteLine(Math.Abs(firstSum - secondSum));

            }
        }
    }


   
