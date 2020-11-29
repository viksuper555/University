using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Test
{
    class Labyrinth
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\viksu\source\repos\App\Test\lab.txt";

            using (var f = File.OpenText(path))
            {
                int size = int.Parse(f.ReadLine());
                var lab = new int[size, size];

                int x = int.Parse(f.ReadLine());
                int y = int.Parse(f.ReadLine());
                Point start = new Point(x,y);

                x = int.Parse(f.ReadLine());
                y = int.Parse(f.ReadLine());
                Point end = new Point(x, y);

                while (!f.EndOfStream)
                {  
                    string[] line = new string[size];
                    for (int row = 0; row < size; row++)
                    {
                        line = f.ReadLine().Split(' ');
                        for (int col = 0; col < line.Length; col++)
                        {
                            lab[row, col] = int.Parse(line[col]);
                        }
                    }
                }

                Trace trace = FindPath(lab, start, end);

                
                Console.WriteLine(trace.ToString());
            }

        }
        private static int[] col = { -1, 0, 0, 1 };
        private static int[] row = { 0, -1, 1, 0 };

        public static Trace FindPath(int [,] lab, Point start, Point end)
        {
            bool[,] visited = new bool[lab.GetLength(0), lab.GetLength(1)];
            Queue<Point> pointsQueue = new Queue<Point>();

            visited[start.y, start.x] = true;

            pointsQueue.Enqueue(start);

            while(pointsQueue.Count > 0)
            {
                Point current = pointsQueue.Dequeue();
                if (current.IsEqual(end))
                {
                    return new Trace(current);
                }

                for (int i = 0; i < 4; i++)
                {
                    if (isValid(ref lab, ref visited, current.x + col[i], current.y + row[i]))
                    {
                        PrintLab(lab, visited);
                        visited[current.y + row[i], current.x + col[i]] = true;
                        Point point = new Point(current.x + col[i], current.y + row[i]);
                        point.parent = current;
                        pointsQueue.Enqueue(point);
                    }
                }
                PrintLab(lab, visited);
            }
            
            return new Trace(null);
        }
        public static bool isValid(ref int[,] lab, ref bool[,] visited, int x, int y)
        {
            int length = lab.GetLength(0);
            return (x >= 0) && (x < length) && (y >= 0) && (y < length)
                    && lab[y, x] == 0 && !visited[y, x];
        }
        public static void PrintLab(int[,] lab, bool[,] vis)
        {
            for (int row = 0; row < vis.GetLength(0); row++)
            {
                Console.Write($"Row {row}: ");
                for (int col = 0; col < vis.GetLength(1); col++)
                {
                    if (vis[row, col])
                        Console.Write("X ");
                    else
                        Console.Write(lab[row,col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(new string('~', vis.GetLength(1)*2));
        }
    }

    internal class Point
    {
        public int x, y;

        public Point parent = null;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public bool IsEqual(Point p)
        {
            return this.x == p.x && this.y == p.y;
        }
    }
    internal class Trace
    {

        int distance;
        public List<Point> points;

        public Trace(Point point)
        {
            this.points = new List<Point>();
            if(point != null)
            {
                points.Add(point);
                Point par = point.parent;
                while (par != null)
                {
                    points.Add(par);
                    distance++;
                    par = par.parent;
                }
            }
            
        }
        
        public override string ToString()
        {
            if (points.Count == 0)
                return "NO PATH";
            var result = "";
            for (int i = distance; i >= 0; i--)
            {
                result += $"({points[i].x}, {points[i].y}) -> ";
            }
            result += "EXIT";
            return result;
        }
    
    }

}
