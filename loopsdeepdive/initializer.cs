using System;

namespace loopsdeepdive
{

    static class Initializer
    {
        public static void ByteLoop(int limit)
        {
            for (byte i = 0; i < limit; i++)
            {
                Console.WriteLine(i.ToString());
            }
        }

        public static void FloatLoop(decimal limit)
        {
            for (decimal i = 0.2m; i < limit; i*=2)
            {
                Console.WriteLine(i.ToString());
            }
        }

        public static void ReverseLoop(decimal start, decimal limit)
        {
            for (decimal i = start; i > limit; i/=2)
            {
                Console.WriteLine(i.ToString());
            }
        }

        public static void DumbLoop(int start, int limit)
        {
            for (int i = start; i < limit; i*=2)
            {
                Console.WriteLine($"i: {i}, limit: {limit}");
                limit++;
                i--;
            }
        }
    }
}
