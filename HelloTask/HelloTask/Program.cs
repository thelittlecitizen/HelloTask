using System;
using System.Threading;

namespace HelloTask
{
    
    class Program
    {

        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;

            //ThreadPool.SetMaxThreads(5, 5);

            for (int i = 0; i < 1000000; i++)
            {
               int number = i;
               ThreadPool.QueueUserWorkItem(obj => Console.WriteLine(number));
            }

            Console.ReadLine();
            Console.WriteLine((DateTime.Now- start).TotalMilliseconds);
        }
        
    }
}
