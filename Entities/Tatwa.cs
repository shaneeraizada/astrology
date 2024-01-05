using Astrology.Enums;

namespace Astrology.Entities
{
    /// <summary>
    /// Tatwa is useful in understanding the human body and its disease.
    /// </summary>
    public class Tatwa
    {
        public string Name { get; set; }
        public Element Element { get; set; }
        public List<string> Attributes { get; set; }
    }
}
