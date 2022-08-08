using HotelListing.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelListing.Controllers
{
    [ApiVersion("2.0", Deprecated = true)]
    [Route("api/country")]
    [ApiController]
    public class CountryV2Controller : ControllerBase
    {
        private readonly DatabaseContext _context;

        public CountryV2Controller(DatabaseContext context)
        {
            _context = context;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetCountries()
        {       
            return Ok(_context.Countries);
        }
    }
}
