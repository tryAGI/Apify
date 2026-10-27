
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CurrentPricingInfoTieredPricing2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tieredPricePerUnitUsd")]
        public double? TieredPricePerUnitUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentPricingInfoTieredPricing2" /> class.
        /// </summary>
        /// <param name="tieredPricePerUnitUsd"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CurrentPricingInfoTieredPricing2(
            double? tieredPricePerUnitUsd)
        {
            this.TieredPricePerUnitUsd = tieredPricePerUnitUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentPricingInfoTieredPricing2" /> class.
        /// </summary>
        public CurrentPricingInfoTieredPricing2()
        {
        }

    }
}