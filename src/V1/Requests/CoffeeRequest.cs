namespace CoffeeRating.DTOs.V1.Requests
{
    public class CoffeeRequest
    {
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
        public long CoffeeRoasteryId { get; set; }
        public CoffeeRoasteryRequest CoffeeRoastery { get; set; }
        //public List<CoffeeBarcode> CoffeeBarcodes { get; set; }
    }
}