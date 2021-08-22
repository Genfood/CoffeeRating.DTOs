using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeRating.DTOs.V1.Responses
{
    public class TokenResponse
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
