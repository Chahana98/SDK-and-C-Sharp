// Parallel Programming:
// Multi-core: Multiple CPUs physically
// Technique to make use of these CPUs in parllel
// .NET has TPL (Task Parallel Library)

// Asynchronous Programming
// AJAX - Asynchronous JavaScript And XML
// Non-blocking I/O
// .NET: async, await

using System;
using System.Threading;
using System.Threading.Tasks;
class ParallelAsync{
    int[] numbers = [22,33,44,55,66,77,1244];
    
    public void ProcessNumbers(){
        // Sequential
        Console.WriteLine("Sequential Implementation");
        foreach(var num in numbers)
        {
            DoWork(num);
        }
        Console.WriteLine("Parallel Implementation");
        ParallelAsync.ForEach(numbers, DoWork);
    }
    public void DoWork(int num){
        Thread.Sleep(1000);    
        Console.WriteLine($"Num: {num}");

        // Making tea
        public async Task IgniteStove(){
            await Task.Delay(5000);
        }
        public async Task PutKeatleyOnWithWater(){
            await Task.Delay(5000);
        }
        public async Task GrindMasala(){
            await Task.Delay(5000);
        }
        public async Task PourChiyaPatti(){
            await Task.Delay(5000);
        }
        public async Task PourSugar(){
            await Task.Delay(5000);
        }
        public void PourMasala(){

        }
        public void PourMilk(){

        }
    }
}