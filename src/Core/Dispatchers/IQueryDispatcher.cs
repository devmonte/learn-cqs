using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Queries;

namespace Core.Dispatchers
{
    public interface IQueryDispatcher
    {
        Task<TResult> Query<TResult>(IQuery<TResult> query);
    }
}
