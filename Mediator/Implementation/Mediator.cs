using Mediator.Abstract;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Implementation
{
    public class Mediator : IMediator
    {
        private readonly Func<Type, object> _serviceResolver;
        private readonly IDictionary<Type, Type> _handlingDetails;
        public Mediator(Func<Type, object> serviceResolver, IDictionary<Type, Type> handleDetails)
        {
            _serviceResolver = serviceResolver;
            _handlingDetails = handleDetails;
        }
        public async Task<TResponse> SendAsync<TResponse>(IRequest<TResponse> request)
        {
            var requestType = request.GetType();
            if (!_handlingDetails.ContainsKey(requestType))
            {
                throw new Exception($"No handler to handle request of type: {requestType.Name}");
            }
            _handlingDetails.TryGetValue(requestType, out var requestHandlerType);
            var handler = _serviceResolver(requestHandlerType);

            return await (Task<TResponse>)handler.GetType().GetMethod("HandleAsync")!
                .Invoke(handler, new[] {request});
        }
    }
}
