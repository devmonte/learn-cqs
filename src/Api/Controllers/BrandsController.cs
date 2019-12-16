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
    public class BrandsController : ControllerBase
    {
        private readonly ILogger<BrandsController> _logger;
        private readonly IMediator _mediator;

        public BrandsController(ILogger<BrandsController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Brand>> GetBrands()
        {
            return await _mediator.Send(new GetBrands());
        }

        [HttpPost]
        public async Task<IActionResult> CreateBrand(CreateBrand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
    }
}
