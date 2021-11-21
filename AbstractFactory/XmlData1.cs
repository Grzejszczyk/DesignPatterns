using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class XmlData1 : IAbstractXml
    {
        public string ReturnDataAsXml()
        {
            return "This is first XML data.";
        }
    }
}
