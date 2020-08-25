using System;
using System.Threading;

namespace HelloTask
{
    
    class Program
    {
        private static int number;

        static void Main(string[] args)
        {
             DateTime start = DateTime.Now;

            for (int i = 0; i < 1000000; i++)
            {
                number = i;
                Thread thread = new Thread(() => Console.WriteLine(number));
                thread.Start();
            }
           
           Console.WriteLine((DateTime.Now- start).TotalMilliseconds);
        }
        
    }
}
