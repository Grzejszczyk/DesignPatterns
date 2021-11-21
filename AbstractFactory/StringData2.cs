using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class StringData2 : IAbstractString
    {
        public string ReturnDataAsString()
        {
            return "This is second string data.";
        }
    }
}
