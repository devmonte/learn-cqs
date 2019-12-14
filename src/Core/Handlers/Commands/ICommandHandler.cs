using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Commands;

namespace Core.Handlers.Commands
{
    public interface ICommandHandler<in T> where T : ICommand
    {
        Task Handle(T command);
    }
}
