using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeRating.DTOs.V1.Responses
{
    public class CoffeeResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CultivationArea { get; set; }
        /// <summary>
        /// Ratio of Arabica in this Coffee.
        /// </summary>
        public int Arabica { get; set; }
        /// <summary>
        ///  Ratio of Robusta in this Coffee.
        /// </summary>
        public int Robusta { get; set; }
        public double AverrageRatingScore { get; set; }
        public List<FlavourResponse> Flavours { get; set; }
        public CoffeeRoasteryResponse CoffeeRoastery { get; set; }
        public List<RatingResponse> Ratings { get; set; }
    }
}
