using BenchmarkDotNet.Running;
using BenchmarkLoop;

class Program
{
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<LoopBenchmark>();
    }
}