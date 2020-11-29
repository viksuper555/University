using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Test
{
    class LettersSet
    {
        public void Main()
        {
            string path = @"C:\Users\viksu\source\repos\App\Test\words.txt";

            int[] totalLettersCount = new int[26];
            char[] letters = new char[26];

            for (char c = 'a'; c <= 'z'; c++)
            {
                letters[c - 'a'] = c;
            }

            using (var f = File.OpenText(path))
            {
                string[] words = File.ReadAllLines(path);
                int[] currentLettersCount = new int[26];
                foreach (var word in words)
                {
                    foreach (var ch in word)
                    {
                        currentLettersCount[Array.IndexOf(letters, ch)]++;
                    }
                    for (int i = 0; i < currentLettersCount.Length; i++)
                    {
                        if (totalLettersCount[i] < currentLettersCount[i])
                            totalLettersCount[i] = currentLettersCount[i];
                    }
                    Array.Clear(currentLettersCount, 0, currentLettersCount.Length);
                }
                for (int i = 0; i < totalLettersCount.Length; i++)
                {

                    for (int j = 0; j < totalLettersCount[i]; j++)
                    {
                        Console.Write(letters[i] + ", ");
                    }
                }


            }
        }
    }
}
