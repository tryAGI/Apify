
#nullable enable

namespace Apify
{
    /// <summary>
    /// A single tier's price-per-dataset-item entry.
    /// </summary>
    public sealed partial class TieredPricingPerDatasetItemEntry
    {
        /// <summary>
        /// Price per unit in USD for this tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tieredPricePerUnitUsd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TieredPricePerUnitUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TieredPricingPerDatasetItemEntry" /> class.
        /// </summary>
        /// <param name="tieredPricePerUnitUsd">
        /// Price per unit in USD for this tier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TieredPricingPerDatasetItemEntry(
            double tieredPricePerUnitUsd)
        {
            this.TieredPricePerUnitUsd = tieredPricePerUnitUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TieredPricingPerDatasetItemEntry" /> class.
        /// </summary>
        public TieredPricingPerDatasetItemEntry()
        {
        }

    }
}