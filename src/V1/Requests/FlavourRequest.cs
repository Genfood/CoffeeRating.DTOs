namespace CoffeeRating.DTOs.V1.Requests
{
    public class FlavourRequest
    {
        /// <summary>
        /// primary key.
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Name.
        /// In the futuer we should support multi languages.
        /// </summary>
        public string Name { get; set; }
    }
}