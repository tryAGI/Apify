
#nullable enable

namespace Apify
{
    /// <summary>
    /// Price per unit for each pricing tier. Present only for tiered `PRICE_PER_DATASET_ITEM` pricing.
    /// </summary>
    public sealed partial class CurrentPricingInfoTieredPricing
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}