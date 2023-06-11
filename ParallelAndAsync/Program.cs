using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

 namespace ParallelAndAsync
 {
    public class Program
    {
        static void Main()
        {
            //Multithreading
            //Thread thread = new Thread();

            //TPL - Task Parallel Library
            //Task task = new Task();

            int[] numbers = {12,24,56,78,43,13,57,89,64};
            Stopwatch stopwatch = new Stopwatch();
            //Sequential computing
            stopwatch.Start();
            foreach(var num in numbers)
            {
                Compute(num);
            }
            Console.WriteLine($"Time taken (Sequential): {stopwatch.ElapsedMilliseconds} ms");

            //Parallel
            stopwatch.Restart();
            Parallel.ForEach(numbers , num => {
                Compute(num);
            });
             Console.WriteLine($"Time taken (Parallel): {stopwatch.ElapsedMilliseconds} ms");



        }

        static void Compute(int x)
        {
            Thread.Sleep(100);
            Console.WriteLine($"Computed for {x}");
        }
    }
 }