using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Commands;
using Core.Handlers.Commands;

namespace Core.Dispatchers
{
    public class CommandDispatcher : ICommandDispatcher
    {
        private readonly IServiceProvider _serviceProvider;

        public CommandDispatcher(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task Send<T>(T command) where T : ICommand
        {
            var handler = (ICommandHandler<T>)_serviceProvider.GetService(typeof(ICommandHandler<T>));
            await handler.Handle(command);
        }
    }
}
