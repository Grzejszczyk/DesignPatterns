using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Report
    {
        public void CreateReport(IData data)
        {
            Console.WriteLine(data.GetData);
        }
    }
}
