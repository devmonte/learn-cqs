using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Dispatchers;
using Core.Models;
using Core.Queries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LearnCqs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BikesController : ControllerBase
    {
        private readonly ILogger<BikesController> _logger;
        private readonly IDispatcher _dispatcher;

        public BikesController(ILogger<BikesController> logger, IDispatcher dispatcher)
        {
            _logger = logger;
            _dispatcher = dispatcher;
        }

        [HttpGet]
        public async Task<IEnumerable<Bike>> Get()
        {
            return await _dispatcher.Query(new GetBikes());
        }
    }
}
