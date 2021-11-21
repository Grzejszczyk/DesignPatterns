using System;

namespace Singleton
{
    public class Singleton
    {
        private Singleton() { }
        private static Singleton _instance;
        public static Singleton GetInstance()
        {
            if (_instance is null)
                _instance = new Singleton();

            return _instance;
        }

        public void SayHelloFromSingleton()
        {
            Console.WriteLine("I'm Singleton. I'll always return the same instance.");
        }
    }
}
