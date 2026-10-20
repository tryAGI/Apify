
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FlatPricePerMonthActorPricingInfoVariant2
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"FLAT_PRICE_PER_MONTH"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricingModel")]
        public string PricingModel { get; set; } = "FLAT_PRICE_PER_MONTH";

        /// <summary>
        /// Number of minutes a user could run the Actor for free before having to rent it. Apify no longer offers rental pricing, so you can see this field only in pricing history and in runs started before rented Actors moved to other pricing models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trialMinutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TrialMinutes { get; set; }

        /// <summary>
        /// Monthly flat price in USD. Apify no longer offers rental pricing, so you can see this field only in pricing history and in runs started before rented Actors moved to other pricing models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricePerUnitUsd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PricePerUnitUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FlatPricePerMonthActorPricingInfoVariant2" /> class.
        /// </summary>
        /// <param name="trialMinutes">
        /// Number of minutes a user could run the Actor for free before having to rent it. Apify no longer offers rental pricing, so you can see this field only in pricing history and in runs started before rented Actors moved to other pricing models.
        /// </param>
        /// <param name="pricePerUnitUsd">
        /// Monthly flat price in USD. Apify no longer offers rental pricing, so you can see this field only in pricing history and in runs started before rented Actors moved to other pricing models.
        /// </param>
        /// <param name="pricingModel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FlatPricePerMonthActorPricingInfoVariant2(
            int trialMinutes,
            double pricePerUnitUsd,
            string pricingModel = "FLAT_PRICE_PER_MONTH")
        {
            this.PricingModel = pricingModel;
            this.TrialMinutes = trialMinutes;
            this.PricePerUnitUsd = pricePerUnitUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FlatPricePerMonthActorPricingInfoVariant2" /> class.
        /// </summary>
        public FlatPricePerMonthActorPricingInfoVariant2()
        {
        }

    }
}