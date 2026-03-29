
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
        [global::System.Text.Json.Serialization.JsonPropertyName("pricingModel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.PricingModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.PricingModel PricingModel { get; set; }

        /// <summary>
        /// For how long this Actor can be used for free in trial period
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trialMinutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TrialMinutes { get; set; }

        /// <summary>
        /// Monthly flat price in USD
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
        /// <param name="pricingModel"></param>
        /// <param name="trialMinutes">
        /// For how long this Actor can be used for free in trial period
        /// </param>
        /// <param name="pricePerUnitUsd">
        /// Monthly flat price in USD
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FlatPricePerMonthActorPricingInfoVariant2(
            global::Apify.PricingModel pricingModel,
            int trialMinutes,
            double pricePerUnitUsd)
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