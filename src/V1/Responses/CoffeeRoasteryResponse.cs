using System.Collections.Generic;

namespace CoffeeRating.DTOs.V1.Responses
{
    public class CoffeeRoasteryResponse
    {

        public long Id { get; set; }
        public string Name { get; set; }
        public List<CoffeeResponse> Coffees { get; set; }
    }
}