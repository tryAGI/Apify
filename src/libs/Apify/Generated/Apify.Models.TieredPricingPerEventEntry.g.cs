
#nullable enable

namespace Apify
{
    /// <summary>
    /// A single tier's price-per-event entry.
    /// </summary>
    public sealed partial class TieredPricingPerEventEntry
    {
        /// <summary>
        /// Price per event in USD for this tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tieredEventPriceUsd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TieredEventPriceUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TieredPricingPerEventEntry" /> class.
        /// </summary>
        /// <param name="tieredEventPriceUsd">
        /// Price per event in USD for this tier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TieredPricingPerEventEntry(
            double tieredEventPriceUsd)
        {
            this.TieredEventPriceUsd = tieredEventPriceUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TieredPricingPerEventEntry" /> class.
        /// </summary>
        public TieredPricingPerEventEntry()
        {
        }

    }
}