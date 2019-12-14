using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Commands;
using Core.Queries;

namespace Core.Dispatchers
{
    public interface IDispatcher
    {
        Task Send<TCommand>(TCommand command) where TCommand : ICommand;
        Task<TResult> Query<TResult>(IQuery<TResult> query);
    }
}
