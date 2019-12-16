using Core.Commands;
using Core.Models;
using Core.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearnCqs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BikesController : ControllerBase
    {
        private readonly ILogger<BikesController> _logger;
        private readonly IMediator _mediator;

        public BikesController(ILogger<BikesController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<Bike>> Get()
        {

            return await _mediator.Send(new GetBikes());
        }

        [HttpPost]
        public async Task<IActionResult> CreateBrand(CreateBike command)
        {
            await _mediator.Send(command);
            return Ok();
        }
    }
}
