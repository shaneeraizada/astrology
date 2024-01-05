using Astrology.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Astrology.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TatwaController : ControllerBase
    {
        private static readonly List<Tatwa> _houses = new List<Tatwa>
            {
                new Tatwa { Name = "Tejas Tatwa",
                    Element = Enums.Element.Fire,
                    Attributes = new List<string> { "Person craves for positions and power" } },
                new Tatwa { Name = "Prithvi Tatwa",
                    Element = Enums.Element.Earth,
                    Attributes = new List<string> { "Person wants to achieve high material success, satisfaction",
                        "Person concentrates on achieving wealth by trade and other means" } },
                new Tatwa { Name = "Akasha Tatwa",
                    Element = Enums.Element.Ethereal,
                    Attributes = new List<string> { "Person craves for learning, sprituality and higher knowledge" } },
                new Tatwa { Name = "Jala Tatwa",
                    Element = Enums.Element.Water,
                    Attributes = new List<string> { "Person is creative, artistic and emotional",
                        "Person succeeds in art and literature" } },
                new Tatwa { Name = "Vayu Tatwa",
                    Element = Enums.Element.Air,
                    Attributes = new List<string> { "Person takes work as workship",
                        "Person is capable of facing more physical and mental stress",
                        "Person achieves goals through hardwork" } }
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