using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Test
{
    class FileAnal
    {
        public void Main()
        {
            Console.WriteLine("Please, enter the file path.");
            string path = Console.ReadLine();

            if (!File.Exists(path))
                throw new ArgumentException("Path not found.");
            int commaSum = 0, pointSum = 0, numberSum = 0;

            using (var f = File.OpenText(path))
            {
                while (!f.EndOfStream)
                {
                    char input = (char)(f.Read());

                    if (input >= '0' && input <= '9')
                    {
                        while (input >= '0' && input <= '9' && !f.EndOfStream)
                        {
                            input = (char)(f.Read());
                        }
                        numberSum++;
                    }
                    if (input == ',')
                        commaSum++;
                    else if (input == '.')
                        pointSum++;

                }
            }
            Console.WriteLine("Total commas: {0}", commaSum);
            Console.WriteLine("Total points: {0}", pointSum);
            Console.WriteLine("Total numbers: {0}", numberSum);
        }
    }
}
