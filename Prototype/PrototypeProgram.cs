using System;

namespace Prototype
{
    public class PrototypeProgram
    {
        public static void Start()
        {
            IPrototype c1 = new Circle(new Shape(1, 2), 10);

            var c2 = c1.Clone();

            c1.ResetCP();
        }
    }
}
