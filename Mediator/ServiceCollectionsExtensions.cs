using Mediator.Abstract;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public static class ServiceCollectionsExtensions
    {
        public static IServiceCollection AddMediator(this IServiceCollection services, ServiceLifetime lifetime, params Type[] markers)
        {
            var handlerInfo = new Dictionary<Type, Type>();

            foreach (var marker in markers)
            {
                var assembly = marker.Assembly;
                var requests = GetClassesImplementongInterface(assembly, typeof(Mediator.Abstract.IRequest<>));
                var handlers = GetClassesImplementongInterface(assembly, typeof(IHandler<,>));

                requests.ForEach(x =>
                {
                    handlerInfo[x] = handlers.SingleOrDefault(xx => x == xx.GetInterface("IHandler`2")!.GetGenericArguments()[0]);
                });

                var serviceDescriptor = handlers.Select(x => new ServiceDescriptor(x, x, lifetime));
                services.TryAdd(serviceDescriptor);
            }

            services.AddSingleton<IMediator>(x => new Mediator.Implementation.Mediator(x.GetRequiredService, handlerInfo));

            return services;
        }

        private static List<Type> GetClassesImplementongInterface(Assembly assembly, Type typeToMatch)
        {
            return assembly.ExportedTypes
                .Where(t =>
                {
                    var genericInterfaces = t.GetInterfaces().Where(x => x.IsGenericType);
                    var implementRequestType = genericInterfaces.Any(x => x.GetGenericTypeDefinition() == typeToMatch);
                    return !t.IsInterface && !t.IsAbstract && implementRequestType;
                }).ToList();
        }
    }
}
