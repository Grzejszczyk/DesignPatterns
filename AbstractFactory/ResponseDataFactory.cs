using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ResponseDataFactory : IAbstractDataFactory
    {
        public IAbstractXml XmlData()
        {
            return new XmlData2();
        }

        public IAbstractString StringData()
        {
            return new StringData2();
        }
    }
}
