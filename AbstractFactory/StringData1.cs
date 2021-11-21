using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class StringData1 : IAbstractString
    {
        public string ReturnDataAsString()
        {
            return "This is first string data.";
        }
    }
}
