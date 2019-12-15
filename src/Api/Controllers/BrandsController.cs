using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Commands;
using Core.Dispatchers;
using Core.Models;
using Core.Queries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LearnCqs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BrandsController : ControllerBase
    {
        private readonly ILogger<BrandsController> _logger;
        private readonly IDispatcher _dispatcher;

        public BrandsController(ILogger<BrandsController> logger, IDispatcher dispatcher)
        {
            _logger = logger;
            _dispatcher = dispatcher;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBrand(CreateBrand command)
        {
            await _dispatcher.Send(command);
            return Ok();
        }
    }
}
