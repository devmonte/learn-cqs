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
    public class BrandsController : ControllerBase
    {
        private readonly ILogger<BrandsController> _logger;
        private readonly IBrandsRepository _brandsRepository;

        public BrandsController(ILogger<BrandsController> logger, IBrandsRepository brandsRepository)
        {
            _logger = logger;
            _brandsRepository = brandsRepository;
        }

        public async Task<List<Brand>> GetBrands()
        {
            return _brandsRepository.GetBrands().ToList();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBrand(Brand brand)
        {
            _brandsRepository.AddBrand(brand);
            return Ok();
        }
    }
}
