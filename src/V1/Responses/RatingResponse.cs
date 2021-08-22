using System;
using System.Collections.Generic;

namespace CoffeeRating.DTOs.V1.Responses
{
    public class RatingResponse
    {
        public long Id { get; set; }
        public string Review { get; set; }
        public int Score { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Date { get; set; }
        public CoffeeBevarageResponse Bevarage { get; set; }
        public PreparationResponse Preparation { get; set; }
        public long CoffeeId { get; set; }
        public CoffeeResponse Coffee { get; set; }
        public UserResponse User { get; set; }
        /// <summary>
        /// Beim hinzufügen eines neuen ratings ist es wichtig das die Primärschlüssel der ausgewählten Flavours sich in der List befinden!
        /// </summary>
        public List<FlavourResponse> Flavours { get; set; }
    }

    public enum CoffeeBevarageResponse
    {
        None = 0,
        Cupping = 1,
        CoffeeBlack = 2,
        Espresso = 3,
        /// <summary>
        /// Milchkaffee
        /// </summary>
        MilkCoffee = 4,
        Cappuccino = 5,
        LatteMacchiato = 6,
        EspressoMacchiato = 7,
        Other = 100
    }

    public enum PreparationResponse
    {
        None = 0,
        Aeropress = 1,
        Bialetti = 2,
        Chemex = 3,
        PadMaschine = 4,
        /// <summary>
        /// Filter Kaffee Maschine
        /// </summary>
        DripCoffeeMaker = 5,
        FrenchPress = 6,
        /// <summary>
        /// Handfilter Kaffee
        /// </summary>
        ManualFilter = 7,
        CapsuleMachine = 8,
        /// <summary>
        /// Siebträger
        /// </summary>
        PortafilterMachine = 9,
        AutomaticCoffeeMachine = 10,
        Other = 100
    }
}