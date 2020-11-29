using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodingGameTask
{
    class Solution
    {
        static void Main(string[] args)
        {
            string[] inputs;
            inputs = Console.ReadLine().Split(' ');
            int w = int.Parse(inputs[0]);
            int h = int.Parse(inputs[1]);
            int countX = int.Parse(inputs[2]);
            int countY = int.Parse(inputs[3]);
            inputs = Console.ReadLine().Split(' ');

            var xValues = new Dictionary<int, int>();
            var yValues = new Dictionary<int, int>();

            for (int i = 0; i < countX; i++)
            {
                int x = int.Parse(inputs[i]);
                xValues.Add(x, 1);
            }
            inputs = Console.ReadLine().Split(' ');
            for (int i = 0; i < countY; i++)
            {
                int y = int.Parse(inputs[i]);
                yValues.Add(y, 1);
            }
            xValues.Add(w, 1);
            yValues.Add(h, 1);
            AddMore(ref xValues);
            AddMore(ref yValues);

            int count = 0;
            foreach (var x in xValues.Keys)
            {
                foreach (var y in yValues.Keys)
                {
                    if (x == y)
                        count += xValues[x] * yValues[y];
                }
            }
            Console.WriteLine(count);
        }

        private static void AddMore(ref Dictionary<int, int> list)
        {
            List<int> keys = list.Keys.ToList();
            foreach (var el in keys)
            {
                foreach (var el2 in keys)
                {
                    var key = el2 - el;
                    if (key > 0)
                    {
                        if (list.ContainsKey(key))
                            list[key] += 1;
                        else
                            list.Add(key, 1);
                    }

                }
            }
        }
    }
}
