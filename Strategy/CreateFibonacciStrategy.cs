using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class CreateFibonacciStrategy : IStrategy
    {
        /// <summary>
        /// Create Fibonacci sequense from argument
        /// </summary>
        /// <param name="data">Count of arguments of Fibonacci sequense</param>
        /// <returns></returns>
        public object DoAlgoritm(object data)
        {
            var arg = (int)data;
            List<int> fibonacciNumbers = new();
            int previous = 0;

            fibonacciNumbers.Add(previous);
            fibonacciNumbers.Add(previous + 1);

            while (fibonacciNumbers.Count <= arg)
            {
                int value = (fibonacciNumbers[fibonacciNumbers.Count - 2])
                    + (fibonacciNumbers[fibonacciNumbers.Count - 1]);
                fibonacciNumbers.Add(value);
            }

            return fibonacciNumbers;
        }
    }
}
