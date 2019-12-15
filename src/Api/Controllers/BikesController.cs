using Core.Models;
using Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnCqs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BikesController : ControllerBase
    {
        private readonly ILogger<BikesController> _logger;
        private readonly IBikesRepository _bikesRepository;

        public BikesController(ILogger<BikesController> logger, IBikesRepository bikesRepository)
        {
            _logger = logger;
            _bikesRepository = bikesRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Bike>> Get()
        {
            return _bikesRepository.GetBikes().ToList();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBrand(Bike bike)
        {
            _bikesRepository.AddBike(bike);
            return Ok();
        }
    }
}
