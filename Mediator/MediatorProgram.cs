using Mediator.Abstract;
using Mediator.Implementation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public static class MediatorProgram
    {
        public static void Start()
        {
            Console.WriteLine("Hello from my Mediator created according Nick Chapsas video from Youtube");

            //created according Nick Chapsas video from Youtube: https://www.youtube.com/watch?v=4e83trumwcM

            var serviceProvider = new ServiceCollection()
                //.AddTransient<PrintToConsoleHandler>()
                .AddMediator(ServiceLifetime.Scoped, typeof(MediatorProgram))
                .BuildServiceProvider();

            //var handlerDictionary = new Dictionary<Type, Type>
            //{
            //    { typeof(PrintToConsoleRequest), typeof(PrintToConsoleHandler)}
            //};

            //IMediator mediator = new Mediator.Implementation.Mediator(serviceProvider.GetRequiredService, handlerDictionary);

            var request = new PrintToConsoleRequest() { Text = "Hello from Mediator." };

            var mediator = serviceProvider.GetService<IMediator>();

            mediator.SendAsync(request);
        }
    }
}
