using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using MediatR;

namespace Core.Queries
{
    public class GetBrands : IRequest<List<Brand>>
    {
        
    }
}
