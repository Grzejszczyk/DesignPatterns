using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class SaleData : IData
    {
        public string GetData => "This is sale data.";
    }
}
