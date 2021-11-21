using System;

namespace Mediator
{
    public static class MadiatorProgram
    {
        public static void Start()
        {
            Component1 component1 = new();
            Component2 component2 = new();

            new Mediator(component1, component2);

            Console.WriteLine("Client triggets operation A.");
            component1.DoA();

            Console.WriteLine();

            Console.WriteLine("Client triggers operation D.");
            component2.DoD();
        }
    }
}
