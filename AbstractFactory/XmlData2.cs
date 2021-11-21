using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class XmlData2 : IAbstractXml
    {
        public string ReturnDataAsXml()
        {
            return "This is second XML data.";
        }
    }
}
