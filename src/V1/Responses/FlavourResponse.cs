namespace CoffeeRating.DTOs.V1.Responses
{
    public class FlavourResponse
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
        /// <summary>
        /// Die einzelnen Tags / Badgets, aus welchem das Geschmacksprofil erstellt wird lassen sich grundsätzlich in 4 Kategorien unterteilen.
        /// </summary>
        public FlavourCategoryResponse Category { get; set; }
    }

    public enum FlavourCategoryResponse
    {
        /// <summary>
        /// Aromen werden primär über die Nase wahrgenommen.
        /// </summary>
        Aroma = 1,
        /// <summary>
        /// Geschmäcker über die Zunge.
        /// </summary>
        Taste = 2,
        /// <summary>
        /// z.B. Konsistenz. / der Körper der Kaffees.
        /// </summary>
        Viscosity = 3,
        /// <summary>
        /// Der Rest, bzw. wenn man es nicht genau zu ordnen kann.
        /// </summary>
        Other = 4
    }
}