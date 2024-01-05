namespace Astrology.Entities
{
    public class House
    {
        public int Number { get; set; }
        public List<string> Names { get; set; }
        public List<string> Attributes { get; set; }
        public List<Planet> Planets { get; set; } = new List<Planet>();
        public List<string> BeneficsInfluence { get; set; }
        public List<string> MaleficsInfluence { get; set; }

    }
}
