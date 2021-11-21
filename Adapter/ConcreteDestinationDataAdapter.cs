using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class ConcreteDestinationDataAdapter : IConcreteAdapter
    {
        private ConcreteDestinationData _destinationData;
        private ConcreteSourceData _sourceData;

        public ConcreteDestinationDataAdapter(ConcreteSourceData sourceData)
        {
            _sourceData = sourceData;
            ConvertToDestination(sourceData);
        }

        public ConcreteDestinationData ConvertToDestination(object sourse)
        {
            var s = sourse as ConcreteSourceData;
            _destinationData = SourceToDestination(s);
            return _destinationData;
        }

        public ConcreteDestinationData GetDestination()
        {
            return _destinationData;
        }

        private ConcreteDestinationData SourceToDestination(ConcreteSourceData sourceData)
        {
            var destination = new ConcreteDestinationData();
            StringBuilder sb = new();

            sb.AppendJoin(" ", $"{sourceData.Id}:", sourceData.FirstName, sourceData.LastName);

            destination.PersonData = sb.ToString();

            return destination;
        }
    }
}
