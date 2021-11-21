using System;

namespace Adapter
{
    public static class AdapterProgram
    {
        public static void Start()
        {
            var source = new ConcreteSourceData() { Id = 0, FirstName = "Jan", LastName = "Kowalski" };
            var destination2 = new ConcreteDestinationDataAdapter(source).GetDestination();
            Console.WriteLine(destination2.PersonData);
        }
    }
}
