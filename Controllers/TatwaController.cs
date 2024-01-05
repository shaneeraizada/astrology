using Astrology.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Astrology.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TatwaController : ControllerBase
    {
        private static readonly List<Tatwa> _tatwas = new List<Tatwa>
            {
                new Tatwa { Name = "Tejas Tatwa",
                    Element = Enums.Element.Fire,
                    Attributes = new List<string> { "Person craves for positions and power" },
                    RulingPlanets = new List<string> { "Sun", "Mars" },
                    Duration = 18,
                    DaysWhenFirst = new List<string> { "Sunday", "Tuesday" } },
                new Tatwa { Name = "Prithvi Tatwa",
                    Element = Enums.Element.Earth,
                    Attributes = new List<string> { "Person wants to achieve high material success, satisfaction",
                        "Person concentrates on achieving wealth by trade and other means" },
                    RulingPlanets = new List<string> { "Mercury" },
                    Duration = 6,
                    DaysWhenFirst = new List<string> { "Wednesday" } },
                new Tatwa { Name = "Akasha Tatwa",
                    Element = Enums.Element.Ethereal,
                    Attributes = new List<string> { "Person craves for learning, sprituality and higher knowledge" },
                    RulingPlanets = new List<string> { "Jupiter" },
                    Duration = 30,
                    DaysWhenFirst = new List<string> { "Thursday" } },
                new Tatwa { Name = "Jala Tatwa",
                    Element = Enums.Element.Water,
                    Attributes = new List<string> { "Person is creative, artistic and emotional",
                        "Person succeeds in art and literature" },
                    RulingPlanets = new List<string> { "Moon", "Venus" },
                    Duration = 12,
                    DaysWhenFirst = new List<string> { "Monday", "Friday" } },
                new Tatwa { Name = "Vayu Tatwa",
                    Element = Enums.Element.Air,
                    Attributes = new List<string> { "Person takes work as workship",
                        "Person is capable of facing more physical and mental stress",
                        "Person achieves goals through hardwork" },
                    RulingPlanets = new List<string> { "Saturn" },
                    Duration = 24,
                    DaysWhenFirst = new List<string> { "Saturday" } }
            };

        private readonly ILogger<HouseController> _logger;

        public TatwaController(ILogger<HouseController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Tatwa> Get()
        {
            return _tatwas.ToArray();
        }
    }
}