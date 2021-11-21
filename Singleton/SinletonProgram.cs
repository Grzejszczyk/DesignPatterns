using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public static class SinletonProgram
    {
        public static void Start()
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Both variables, contain the same instance");
                s1.SayHelloFromSingleton();
                s2.SayHelloFromSingleton();
            }
            else
            {
                Console.WriteLine("Both variables, return different instances");
            }
        }
    }
}
