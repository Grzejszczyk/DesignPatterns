using Mediator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Implementation
{
    public class PrintToConsoleHandler : IHandler<PrintToConsoleRequest, bool>
    {
        public Task<bool> HandleAsync(PrintToConsoleRequest request)
        {
            Console.WriteLine(request.Text);
            return Task.FromResult(true);
        }
    }
}
