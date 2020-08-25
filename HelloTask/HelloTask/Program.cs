using System;

namespace HelloTask
{
    
    class Program
    {

        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            for (int i= 0; i<1000000; i++)
                Console.WriteLine($"the num is {i}");
            Console.WriteLine((DateTime.Now- start).TotalMilliseconds);
        }
    }
}
