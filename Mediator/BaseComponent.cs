using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class BaseComponent
    {
        protected IMediatorSimple _mediator;
        public BaseComponent(IMediatorSimple mediator = null)
        {
            _mediator = mediator;
        }
        public void SetMediator(IMediatorSimple mediator)
        {
            _mediator = mediator;
        }
    }
}
