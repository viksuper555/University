using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Test
{
    class ReadRows
    {
        static void Main(string[] argss)
        {
            int[] args = Console.ReadLine().Split(", ").Select(x => int.Parse(x)).ToArray();
            string result = "";
            for (int i = 0; i < args.Length; i++)
            {
                if (i >= args.Length - 2)
                {
                    result += args[i].ToString();
                    if (i != args.Length - 1)
                        result += ",";
                }
                else
                {
                    if (args[i] != args[i + 1] - 1)
                    {
                        result += args[i].ToString(); result += ",";
                    }
                    else
                    {
                        int temp, j;
                        for (j = i; j < args.Length - 1; j++)
                        {
                            if (args[j] == args[j + 1] - 1)
                            {
                                temp = args[j + 1];
                            }
                            else
                            {
                                break;
                            }
                        }
                        if(i!=j-1)
                        {
                            result += $"{args[i]}-{args[j]},";
                        }
                        else
                        {
                            result += $"{args[i]},{args[j]},";
                        }
                        i = j + 1;
                    }

                }

            }
            Console.WriteLine(result.Substring(0,result.Length-1));
            
        }
    
    }
}
