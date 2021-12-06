using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public interface IMediatorSimple
    {
        void Notify(object sender, string ev);
    }
}
