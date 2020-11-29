using System;

namespace Test
{
    class Program
    {
        public void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(NOfSequence(n));
            Console.WriteLine(NOfSequenceReccursive(n));
        }

        private static int NOfSequence(int n)
        {
            int A1 = 2, A2 = 4, A3 = 6;
            int result = 0;
            if (n == 1)
                return A1;
            else if (n == 2)
                return A2;
            else if (n == 3)
                return A3;
            for (int i = 3; i < n; i++)
            {
                result = 3 * A1 + 4 * A2 - 7 * A3;
                A1 = A2;
                A2 = A3;
                A3 = result;
            }
            return result;
        }

        private static int NOfSequenceReccursive(int n)
        {
            if (n == 1)
                return 2;
            if (n == 2)
                return 4;
            if (n == 3)
                return 6;
            return 3*NOfSequenceReccursive(n - 3) + 4 * NOfSequenceReccursive(n - 2) - 7 * NOfSequenceReccursive(n - 1);
        }

    }
}
