using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Commands;
using Core.Queries;

namespace Core.Dispatchers
{
    public class Dispatcher : IDispatcher
    {
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly ICommandDispatcher _commandDispatcher;

        public Dispatcher(IQueryDispatcher queryDispatcher, ICommandDispatcher commandDispatcher)
        {
            _queryDispatcher = queryDispatcher;
            _commandDispatcher = commandDispatcher;
        }

        public Task Send<TCommand>(TCommand command) where TCommand : ICommand
        {
            return _commandDispatcher.Send(command);
        }

        public Task<TResult> Query<TResult>(IQuery<TResult> query)
        {
            return _queryDispatcher.Query(query);
        }
    }
}
