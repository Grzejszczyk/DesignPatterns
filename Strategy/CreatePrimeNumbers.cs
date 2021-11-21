using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class CreatePrimeNumbers : IStrategy
    {
        /// <summary>
        /// Prime Numbers sequense from argument
        /// </summary>
        /// <param name="data">First argument of Prime Numbers</param>
        /// <returns></returns>
        public object DoAlgoritm(object data)
        {
            var arg = (int)data;
            List<int> primeNumbers = new();

            for (int i = arg; primeNumbers.Count <= 10; i++)
            {
                if (CheckIsPrimeNum(i)) primeNumbers.Add(i);
            }

            return primeNumbers;
        }

        private bool CheckIsPrimeNum(int a)
        {
            int num = 2;

            if (a == 0) return false;
            if (a == 1) return false;
            if (a == 2) return true;

            while (num < a)
            {
                if (a % num != 0)
                {
                    num++;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
