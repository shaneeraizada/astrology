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
                    Names = new List<string> { "Dwitiya Bhav", "Dhan Bhav", "Kutumba Bhav", "Marak Bhav" }, 
                    Attributes = new List<string> { "Speech", "Face", "Right eye", "Eye sight",
                        "Nose", "Mouth", "Money", "Monetary savings", "Charity one does with money",
                        "Gifts one receives", "Eating habits", "Childhood family", "Basic education",
                        "If 6/8/12 lord is in the second house, the person finds it difficult to do savings",
                        "If malefic planet placed in second house is exalted or in own house, positive results will follow and person will have lots of wealth" },
                    Planets = new List<Planet> { },
                    BeneficsInfluence = new List<string> { "Good speaking skills", 
                        "Speaks in a polite & gentle manner", "Good reasoning power", 
                        "Good in debate", "Speaks truth", "Rich", "Wealthy", "Loves to do charity" },
                    MaleficsInfluence = new List<string> { "Harsh unrefined language",
                        "May have a tendency to lie", "Difficult to save money",
                        "Work hard to earn money", "May cause marks or scars on face",
                        "Problems related to eyes, nose, mouth, etc" }
                },
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