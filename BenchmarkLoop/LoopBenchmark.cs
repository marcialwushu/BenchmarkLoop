
using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BenchmarkLoop
{
    public  class LoopBenchmark
    {
        private int[] array;

        List<int> list;

        [GlobalSetup]
        public void Setup()
        {
            array = new int[10];
            list = new List<int>(array);
        }

        [Benchmark]
        public void ForLoop()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 2;
            }

        }

        [Benchmark]
        public void ParallelForLoop()
        {
            Parallel.For(0, array.Length, i =>
            {
                array[i] = i * 2;
            });
        }

        [Benchmark]
        public void ParallelLINQ()
        {
            //int[] array = new int[1000];

            array = array.AsParallel().Select(i => i * 2).ToArray();
        }

        [Benchmark]
        public async Task TaskAsyncAwait()
        {
            //int[] array = new int[1000];
            await Task.WhenAll(
                Enumerable.Range(0, array.Length).Select(i => Task.Run(() =>
                {
                    array[i] = i * 2;
                }))
            );
        }

        [Benchmark]
        public async Task TaskChannels()
        {
            //int[] array = new int[1000];
            var channel = Channel.CreateUnbounded<int>();

            var producer = Task.Run(async () =>
            {
                for (int i = 0; i < array.Length; i++)
                {
                    await channel.Writer.WriteAsync(i);
                }
                channel.Writer.Complete();
            });

            var consumer = Task.Run(async () =>
            {
                await foreach (var item in channel.Reader.ReadAllAsync())
                {
                    array[item] = item * 2;
                }
            });

            await Task.WhenAll(producer, consumer);
        }

        [Benchmark]
        public void CollectionMarshalAsSpan()
        {
            //List<int> list = new List<int>(new int[1000]);

            // Obter o Span<int> da lista usando CollectionMarshal.AsSpan
            Span<int> span = CollectionsMarshal.AsSpan(list);

            for (int i = 0; i < span.Length; i++)
            {
                span[i] = i * 2;
            }

        }
    }
}
