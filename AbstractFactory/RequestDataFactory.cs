using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class RequestDataFactory : IAbstractDataFactory
    {
        public IAbstractXml XmlData()
        {
            return new XmlData1();
        }

        public IAbstractString StringData()
        {
            return new StringData1();
        }
    }
}
