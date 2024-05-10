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

            Task.WaitAll(MethodWith5Sec(), MethodWith7Sec(), MethodWith2Sec());
            sw.Stop();

            var elapsed = sw.ElapsedMilliseconds;
            Console.WriteLine($"Total Elapsed: {elapsed} ms");
        }
        static async Task MethodWith5Sec()
        {
            await Task.Delay(5000);
            Console.WriteLine("MethodWith5Sec finished");
        }

        static async Task MethodWith7Sec()
        {
            await Task.Delay(7000);
            Console.WriteLine("MethodWith7Sec finished");
        }

        static async Task MethodWith2Sec()
        {
            await Task.Delay(2000);
            Console.WriteLine("MethodWith2Sec finished");
        }

        
    }
}
