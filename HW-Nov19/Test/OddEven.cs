using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Test
{
    class OddEven
    {
        public void Main()
        {
            string path = @"C:\Users\viksu\source\repos\App\Test\matrix.txt";


            using (var f = File.OpenText(path))
            {
                string[] lines = File.ReadAllLines(path);
                int n = lines.Length;
                var matrix = new int[n, n];

                for (int row = 0; row < n; row++)
                {
                    string[] rowNumbers = lines[row].Split(' ');

                    for (int col = 0; col < n; col++)
                    {
                        matrix[row, col] = int.Parse(rowNumbers[col]);
                    }
                }
                int evenNOddRow = 0, oddNEvenCol = 0;

                for (int row = 1; row <= n; row++)
                {
                    for (int col = 1; col <= n; col++)
                    {
                        int numb = matrix[row - 1, col - 1];
                        if (numb % 2 == 0 && row % 2 != 0)
                            evenNOddRow += numb;
                        else if (numb % 2 != 0 && col % 2 == 0)
                            oddNEvenCol += numb;

                    }
                }
                Console.WriteLine("Total even numbers in odd rows : {0}", evenNOddRow);
                Console.WriteLine("Total odd numbers in even columns : {0}", oddNEvenCol);

            }
        }
    }
}
