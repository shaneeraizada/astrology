namespace Astrology.Entities
{
    public class Planet
    {
        public string Name { get; set; }
        public string Attributes { get; set; }
        public int Position { get; set; }
        public List<ZodiacSign> ZodiacSign { get; set; }
        public bool IsNaturalBenefic { get; set; }
        public bool IsNaturalMalefic { get; set; }
    }
}
