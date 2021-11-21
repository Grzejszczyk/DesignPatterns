using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public static class StrategyProgram
    {
        public static void Start()
        {
            Console.WriteLine("Hello Strategy!");

            var ctx = new Context(new CreateFibonacciStrategy());
            var fib = (List<int>)ctx.DoLogic(10);

            ctx.SetStrategy(new CreatePrimeNumbers());
            var priNo = (List<int>)ctx.DoLogic(10);

            Console.WriteLine($"This is result from strategy: {nameof(CreateFibonacciStrategy)}");
            Console.WriteLine("Fibonacci:");
            foreach (var item in fib)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine($"This is result from strategy: {nameof(CreatePrimeNumbers)}");
            Console.WriteLine("Prime numbers:");
            foreach (var item in priNo)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("End of Strategy demo.");
            Console.WriteLine("");
        }

    }
}
