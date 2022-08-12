using BenchmarkDotNet.Running;
using System;

namespace AutoMapperBnechmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<AutoMapperBenchmark>();
            Console.ReadKey();
        }
    }
}
