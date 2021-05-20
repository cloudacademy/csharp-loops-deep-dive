using System;

namespace loopsdeepdive
{

    static class WhileLoop
    {
        public static void ForLoop(int limit)
        {
            int i = 1;
            while (i < limit)
            {
                Console.WriteLine(i.ToString());
                i++;
            }
        }

        public static void IsFinished()
        {
            int i = 0;
            bool finished = false;
            DateTime endTime = DateTime.Now.AddSeconds(5);
            Random random = new Random();
            while (endTime > DateTime.Now && !finished)
            {          
                Console.WriteLine($"i: {i}, {DateTime.Now.ToString("hh:mm:ss.fff")}");
                System.Threading.Thread.Sleep(random.Next(10, 500));
                finished = i++ == 9;    
            }
        }


    }
}
