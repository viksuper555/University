using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Test
{
    class ProcessingMatrix
    {
        public void Main()
        {
            string path = @"C:\Users\viksu\source\repos\App\Test\matrix.txt";

            using (var f = File.OpenText(path))
            {
                int rows = int.Parse(f.ReadLine());
                int cols = int.Parse(f.ReadLine());
                var matrix = new decimal[rows, cols];
                int currRow = 0;
                while (!f.EndOfStream)
                {   
                    string[] input = f.ReadLine().Split(' ');
                    for (int i = 0; i < input.Length; i++)
                    {
                        matrix[currRow, i] = decimal.Parse(input[i]);
                    }
                    currRow++;
                }
            }
        }
        private static void PrintMatrix(decimal[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
        private static bool CheckIdentity(decimal[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if(row == col && matrix[row,col] != 1)
                        return false;
                    if (row != col && matrix[row, col] == 1)
                        return false;

                }
            }
            return true;
        }
    
        private static decimal SumNegativeOnAntiDiagonal(decimal[,] matrix)
        {
            decimal sum = 0;
            int cols = matrix.GetLength(1) - 1;
            int rows = matrix.GetLength(0) - 1;
            for (int i = cols; i >= Math.Abs(cols - rows); i--)         //Start from top-right corner, iterate until difference
            {
                if (matrix[cols - i, i] < 0)
                    sum += matrix[cols - i, i];
            }

            return sum;
        }
    
        private static void NormalizeRows(ref decimal[,] matrix)
        {
            decimal sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[row, col]*matrix[row, col];
                }
                sum = (decimal)Math.Sqrt((double)sum);              //Possible loss of data :/

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] != 0)
                        matrix[row, col] /= sum;
                }
            }
        }

        private static void SortMatrix(ref decimal[,] matrix)
        {      
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                decimal[] temp = new decimal[matrix.GetLength(0)];
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    temp[row] = matrix[row, col];
                }
                if(col % 2 == 0)
                    BubbleSort(ref temp, SortType.Ascending);
                else
                    BubbleSort(ref temp, SortType.Descending);

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = temp[row];
                }

            }
        }
        enum SortType
        {
            Ascending,
            Descending
        }
        private static void BubbleSort(ref decimal[] arr, SortType sortType)
        {
            decimal temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (((int)sortType == 0) ? arr[i] > arr[i + 1] : arr[i] < arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }
    }
}
