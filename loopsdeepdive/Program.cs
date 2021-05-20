using System;

namespace loopsdeepdive
{
    class Program
    {
        static void Main(string[] args)
        {
            Initializer.ByteLoop(256);
            Initializer.FloatLoop(25.7m);
            Initializer.ReverseLoop(25.6m, 0.1m); 
            Initializer.DumbLoop(3, 9);  

            WhileLoop.ForLoop(12);
            WhileLoop.IsFinished();            
        }
    }
}

























