using Astrology.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Astrology.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlanetController : ControllerBase
    {
        private static readonly List<Planet> _planets = new List<Planet>
            {
                new Planet { Name = "Sun", Description = "", Position = -1, ZodiacSign = new List<ZodiacSign> { new ZodiacSign { Name = "Leo" } }, IsBenefic = false, IsMalefic = true },
                new Planet { Name = "Moon", Description = "", Position = -1, ZodiacSign = new List<ZodiacSign> { new ZodiacSign { Name = "Cancer" } }, },
                new Planet { Name = "Mercury", Description = "", Position = -1, ZodiacSign = new List<ZodiacSign> { new ZodiacSign { Name = "Gemini" }, new ZodiacSign { Name = "Virgo" } }, IsBenefic },
                new Planet { Name = "Venus", Description = "", Position = -1, ZodiacSign = new List<ZodiacSign> { new ZodiacSign { Name = "Libra" }, new ZodiacSign { Name = "Taurus" } }, },
                new Planet { Name = "Mars", Description = "", Position = -1, ZodiacSign = new List<ZodiacSign> { new ZodiacSign { Name = "Aries" }, new ZodiacSign { Name = "Scorpio" } }, },
                new Planet { Name = "Jupiter", Description = "", Position = -1, ZodiacSign = new List<ZodiacSign> { new ZodiacSign { Name = "Sagittarius" }, new ZodiacSign { Name = "Pisces" } }, },
                new Planet { Name = "Saturn", Description = "", Position = -1, ZodiacSign = new List<ZodiacSign> { new ZodiacSign { Name = "Capricorn" }, new ZodiacSign { Name = "Aquarius" } }, },
                new Planet { Name = "Uranus", Description = "", Position = -1, ZodiacSign = new List<ZodiacSign> { new ZodiacSign { Name = "Aquarius" } }, },
                new Planet { Name = "Neptune", Description = "", Position = -1, ZodiacSign = new List<ZodiacSign> { new ZodiacSign { Name = "Pisces" } }, },
                new Planet { Name = "Pluto", Description = "", Position = -1, ZodiacSign = new List<ZodiacSign> { new ZodiacSign { Name = "Scorpio" } }, },
            };

        private readonly ILogger<PlanetController> _logger;

        public PlanetController(ILogger<PlanetController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Planet> Get()
        {
            return _planets.ToArray();
        }
    }
}