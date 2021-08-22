using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeRating.DTOs.V1.Responses
{
    public class UserResponse
    {
        public string Id { get; set; }
        public string UserName { get; set; }

        public List<RatingResponse> Ratings { get; set; }
    }
}
