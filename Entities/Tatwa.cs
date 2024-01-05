using Astrology.Enums;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Security.Claims;

namespace Astrology.Entities
{
    /// <summary>
    /// Tatwa is useful in understanding the human body and its disease.
    /// Tatwa/Element Prithvi Jala Tejas Vayu Akasha Total
    /// Duration in minutes 6 12 18 24 30 90
    /// The total time for all the five tatwas adds up to 90 minutes or 1 ½ hours. Generally,
    /// after sunrise first 1 ½ hours(90 min) tatwa cycle will be in the ascending order which
    /// is called Aroha cycle.
    /// The descending cycle of 1 ½ hours(90 min) is called Avaroha cycle and
    /// The tatwas climb down top tatwa to the bottom tatwa.
    /// The special feature is each day starts with specific tatwa according to the week day 
    /// and continues in succession in Aroha and Avaroha cycle.
    /// On Sunday or Tuesday the first tatwa is “Tejas tatwa” of 18 mins and goes in the 
    /// ascending order 18, 24, 30, 6 and 12 which makes 1 ½ hours (90 min). While descending 
    /// it starts from 12, 6, 30, 24, and 18 , another cycle of 90 min.
    /// On Wednesday the first tatwa is Prithvi tatwa.
    /// On Thursday the first tatwa is Akash tatwa.
    /// On Monday and Friday the first tatwa is Jala tatwa and
    /// On Saturday the first tatwa is Vayu tatwa .
    /// </summary>
    public class Tatwa
    {
        public string Name { get; set; }
        public Element Element { get; set; }
        public List<string> Attributes { get; set; }
        public List<string> RulingPlanets { get; set; }
        public int Duration { get; set; }
        public List<string> DaysWhenFirst { get; set; }
    }
}
