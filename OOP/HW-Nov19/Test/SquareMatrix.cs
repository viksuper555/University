using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Test
{
    class SquareMatrix
    {
        public void Main()
        {
            int N = int.Parse(Console.ReadLine());

            string path = @"C:\Users\viksu\source\repos\App\Test\matrix.txt";

            var matrix = new string[N, N];               //The matrix is a string, so any missing values will be null 
            using (var f = File.OpenText(path))         //instead of 0, so we can recognize them 
            {
                while (!f.EndOfStream)
                {
                    string[] input = f.ReadLine().Split('\t');      //Read input and initialize matrix
                    int[] line = new int[input.Length];
                    for (int i = 0; i < input.Length; i++)
                    {
                        line[i] = int.Parse(input[i]);
                    }
                    int row = line[0];
                    int col = line[1];
                    matrix[row, col] = line[2].ToString();
                }
            }

            for (int row = 0; row < N; row++)                       //Print the matrix
            {
                for (int col = 0; col < N; col++)
                {
                    if (matrix[row, col] == null)
                        matrix[row, col] = "-1";
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
            int oddSum = 0, evenSum = 0, evenRowSum = 0, oddColSum = 0;

            for (int row = 0; row < N; row++)                        //Calculate all the sums
            {
                for (int col = 0; col < N; col++)
                {
                    var n = int.Parse(matrix[row, col]);
                    if (n % 2 == 0)
                        evenSum += n;
                    else
                        oddSum += n;
                    if (row % 2 == 0)
                        evenRowSum += n;
                    if (col % 2 != 0)
                        oddColSum += n;
                }
            }
            Console.WriteLine($"Even sum = {evenSum} \nOdd sum = {oddSum} " +
                $"\nEven row sum = {evenRowSum} \nOdd col sum = {oddColSum}");

        }

    }
}
