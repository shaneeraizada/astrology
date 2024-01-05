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
                new Planet { Name = "Sun",
                    Attributes = "", 
                    Position = -1, 
                    ZodiacSign = new List<ZodiacSign> { new ZodiacSign { Name = "Leo" } }, 
                    IsNaturalBenefic = false, 
                    IsNaturalMalefic = true },
                new Planet { Name = "Moon", 
                    Attributes = "Person has fair stature, pale complexion, round face, bright eyes, thick and short arms", 
                    Position = -1, 
                    ZodiacSign = new List<ZodiacSign> { new ZodiacSign { Name = "Cancer" } }, 
                    IsNaturalBenefic = false, 
                    IsNaturalMalefic = true },
                new Planet { Name = "Mercury", 
                    Attributes = "Person has deep forehead, straight nose, thin lips, narrow face and strong memory", 
                    Position = -1, 
                    ZodiacSign = new List<ZodiacSign> { new ZodiacSign { Name = "Gemini" }, new ZodiacSign { Name = "Virgo" } }, 
                    IsNaturalBenefic = true, 
                    IsNaturalMalefic = false },
                new Planet { Name = "Venus", 
                    Attributes = "Person is good looking with sparkling eyes, Smooth faces with dimples on cheeks", 
                    Position = -1, 
                    ZodiacSign = new List<ZodiacSign> { new ZodiacSign { Name = "Libra" }, new ZodiacSign { Name = "Taurus" } }, 
                    IsNaturalBenefic = true, 
                    IsNaturalMalefic = false },
                new Planet { Name = "Mars", 
                    Attributes = "", 
                    Position = -1, 
                    ZodiacSign = new List<ZodiacSign> { new ZodiacSign { Name = "Aries" }, new ZodiacSign { Name = "Scorpio" } }, 
                    IsNaturalBenefic = false, 
                    IsNaturalMalefic = true },
                new Planet { Name = "Jupiter", 
                    Attributes = "Person is wise, magnamonius, jovial and mild in his actions", 
                    Position = -1, 
                    ZodiacSign = new List<ZodiacSign> { new ZodiacSign { Name = "Sagittarius" }, new ZodiacSign { Name = "Pisces" } }, 
                    IsNaturalBenefic = true, 
                    IsNaturalMalefic = false },
                new Planet { Name = "Saturn", 
                    Attributes = "", Position = -1, ZodiacSign = new List<ZodiacSign> { new ZodiacSign { Name = "Capricorn" }, new ZodiacSign { Name = "Aquarius" } }, IsNaturalBenefic = false, IsNaturalMalefic = true },
                new Planet { Name = "Uranus", 
                    Attributes = "", Position = -1, ZodiacSign = new List<ZodiacSign> { new ZodiacSign { Name = "Aquarius" } }, IsNaturalBenefic = false, IsNaturalMalefic = true },
                new Planet { Name = "Neptune", 
                    Attributes = "", Position = -1, ZodiacSign = new List<ZodiacSign> { new ZodiacSign { Name = "Pisces" } }, IsNaturalBenefic = false, IsNaturalMalefic = true },
                new Planet { Name = "Pluto", 
                    Attributes = "", Position = -1, ZodiacSign = new List<ZodiacSign> { new ZodiacSign { Name = "Scorpio" } }, IsNaturalBenefic = false, IsNaturalMalefic = true },
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