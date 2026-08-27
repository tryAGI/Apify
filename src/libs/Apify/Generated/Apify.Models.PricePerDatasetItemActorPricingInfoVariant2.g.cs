
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
        /// <default>"PRICE_PER_DATASET_ITEM"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricingModel")]
        public string PricingModel { get; set; } = "PRICE_PER_DATASET_ITEM";

        /// <summary>
        /// Name of the unit that is being charged
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unitName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UnitName { get; set; }

        /// <summary>
        /// Price per unit in USD. Mutually exclusive with `tieredPricing` - exactly one of the two is present<br/>
        /// on a pricing record.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricePerUnitUsd")]
        public double? PricePerUnitUsd { get; set; }

        /// <summary>
        /// Tiered price-per-dataset-item pricing, keyed by subscription tier (e.g. `FREE`, `BRONZE`, `SILVER`, `GOLD`,<br/>
        /// `PLATINUM`, `DIAMOND`). The actual price applied to a run is resolved from the user's tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tieredPricing")]
        public global::System.Collections.Generic.Dictionary<string, global::Apify.TieredPricingPerDatasetItemEntry>? TieredPricing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricePerDatasetItemActorPricingInfoVariant2" /> class.
        /// </summary>
        /// <param name="unitName">
        /// Name of the unit that is being charged
        /// </param>
        /// <param name="pricePerUnitUsd">
        /// Price per unit in USD. Mutually exclusive with `tieredPricing` - exactly one of the two is present<br/>
        /// on a pricing record.
        /// </param>
        /// <param name="tieredPricing">
        /// Tiered price-per-dataset-item pricing, keyed by subscription tier (e.g. `FREE`, `BRONZE`, `SILVER`, `GOLD`,<br/>
        /// `PLATINUM`, `DIAMOND`). The actual price applied to a run is resolved from the user's tier.
        /// </param>
        /// <param name="pricingModel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricePerDatasetItemActorPricingInfoVariant2(
            string unitName,
            double? pricePerUnitUsd,
            global::System.Collections.Generic.Dictionary<string, global::Apify.TieredPricingPerDatasetItemEntry>? tieredPricing,
            string pricingModel = "PRICE_PER_DATASET_ITEM")
        {
            this.PricingModel = pricingModel;
            this.UnitName = unitName ?? throw new global::System.ArgumentNullException(nameof(unitName));
            this.PricePerUnitUsd = pricePerUnitUsd;
            this.TieredPricing = tieredPricing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricePerDatasetItemActorPricingInfoVariant2" /> class.
        /// </summary>
        public PricePerDatasetItemActorPricingInfoVariant2()
        {
        }

        /// <summary>
        /// Creates a new <see cref="PricePerDatasetItemActorPricingInfoVariant2"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static PricePerDatasetItemActorPricingInfoVariant2 FromUnitName(string unitName)
        {
            return new PricePerDatasetItemActorPricingInfoVariant2
            {
                UnitName = unitName,
            };
        }

    }
}