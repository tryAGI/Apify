
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PricePerDatasetItemActorPricingInfoVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricingModel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.PricingModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.PricingModel PricingModel { get; set; }

        /// <summary>
        /// Name of the unit that is being charged
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unitName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UnitName { get; set; }

        /// <summary>
        /// 
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
        /// Initializes a new instance of the <see cref="PricePerDatasetItemActorPricingInfoVariant2" /> class.
        /// </summary>
        /// <param name="pricingModel"></param>
        /// <param name="unitName">
        /// Name of the unit that is being charged
        /// </param>
        /// <param name="pricePerUnitUsd"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricePerDatasetItemActorPricingInfoVariant2(
            global::Apify.PricingModel pricingModel,
            string unitName,
            double pricePerUnitUsd)
        {
            this.PricingModel = pricingModel;
            this.UnitName = unitName ?? throw new global::System.ArgumentNullException(nameof(unitName));
            this.PricePerUnitUsd = pricePerUnitUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricePerDatasetItemActorPricingInfoVariant2" /> class.
        /// </summary>
        public PricePerDatasetItemActorPricingInfoVariant2()
        {
        }
    }
}