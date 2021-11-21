using AbstractFactory;
using Adapter;
using Builder;
using FactoryMethod;
using Mediator;
using Prototype;
using Singleton;
using Strategy;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethodProgram.Start();
            StrategyProgram.Start();
            SinletonProgram.Start();
            AbstractFactoryProgram.Start();
            BuilderProgram.Start();
            PrototypeProgram.Start();
            AdapterProgram.Start();
            MadiatorProgram.Start();
        }
    }
}