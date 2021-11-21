using System;

namespace AbstractFactory
{
    public class AbstractFactoryProgram
    {
        public static void Start()
        {
            Console.WriteLine("Testing first factory...");
            ClientMethod(new RequestDataFactory());
            Console.WriteLine("Testing second factory...");
            ClientMethod(new ResponseDataFactory());
        }

        public static void ClientMethod(IAbstractDataFactory factory)
        {
            var str = factory.StringData();
            var xml = factory.XmlData();

            Console.WriteLine(str.ReturnDataAsString());
            Console.WriteLine(xml.ReturnDataAsXml());
        }
    }
}
