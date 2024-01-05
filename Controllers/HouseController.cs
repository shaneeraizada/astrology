using Astrology.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Astrology.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HouseController : ControllerBase
    {
        private static readonly List<House> _houses = new List<House>
            {
                new House { Number = 1, Names = new List<string> {}, Attributes = new List<string> { }, Planets = new List<Planet> { } },
                new House { Number = 2, 
                    Names = new List<string> { "Dhan Bhav", "Kutumba Bhav", "Marak Bhav" }, 
                    Attributes = new List<string> { "Speech", "Face", "Right eye", "Eye sight",
                        "Nose", "Mouth", "Money", "Monetary savings", "Charity one does with money",
                        "Gifts one receives", "Eating habits", "Childhood family", "Basic education",
                        "If under the influence of benefics, the person has good speaking skills, speaks in a polite & gentle manner, good reasoning power, good in debate, speaks truth",
                        "If under the influence of malefics  the person uses harsh unrefined language, may have a tendency to lie" },
                    Planets = new List<Planet> { } },
            };

        private readonly ILogger<HouseController> _logger;

        public HouseController(ILogger<HouseController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<House> Get()
        {
            return _houses.ToArray();
        }
    }
}