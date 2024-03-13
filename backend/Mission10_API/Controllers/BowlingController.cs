using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10_API.Models;
using System.Reflection.Metadata.Ecma335;

namespace Mission10_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlingController : ControllerBase
    {
        private IBowlersRepository _bowlersrepository;

        public BowlingController(IBowlersRepository temp)
        {
            _bowlersrepository = temp;
        }

        //public IEnumerable<Bowler> Get()
        //{
        //    var bowlerData = _bowlersrepository.Bowlers.ToArray();

        //    return bowlerData;
        //}

        [HttpGet("marlins-sharks")]
        public IActionResult GetBowlersForMarlinsAndSharks()
        {
            var bowlers = _bowlersrepository.GetBowlersForMarlinsAndSharks();
            return Ok(bowlers);
        }
    }
}
