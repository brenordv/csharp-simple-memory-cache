using System;
using System.Threading;

namespace SimpleMemoryCache
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SimpleCache.UserCode = "Foo";
            
            Thread.Sleep(5000);
            Console.WriteLine($"UserCode after 5 seconds: {SimpleCache.UserCode}");
            
            Thread.Sleep(5000);
            Console.WriteLine($"UserCode after 10 seconds: {SimpleCache.UserCode}");
            
            Console.WriteLine("All done!");
        }
    }
}