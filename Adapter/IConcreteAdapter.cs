using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface IConcreteAdapter
    {
        ConcreteDestinationData ConvertToDestination(object sourse);
        ConcreteDestinationData GetDestination();
    }
}
