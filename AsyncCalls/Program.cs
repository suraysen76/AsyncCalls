using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AsyncCalls
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();

            Task.WaitAll(MethodWithSec(7), MethodWithSec(2), MethodWithSec(5), MethodWithSec(10));
            sw.Stop();

            var elapsed = sw.ElapsedMilliseconds;
            Console.WriteLine($"Total Time Elapsed: {elapsed} ms");
        }
        static async Task  MethodWithSec<T>(T sec)
        {
            await Task.Delay((Convert.ToInt32(sec)*1000));
            Console.WriteLine("MethodWith{0}Sec finshed",sec);
        }
    }
}
