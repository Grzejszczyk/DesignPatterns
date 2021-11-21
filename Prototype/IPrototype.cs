using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public interface IPrototype
    {
        IPrototype Clone();
        Tuple<int, int> GetCenterPoint(IPrototype prototype);
        void ResetCP();
    }
}
