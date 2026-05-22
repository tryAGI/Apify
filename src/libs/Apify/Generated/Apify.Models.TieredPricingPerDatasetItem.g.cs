
#nullable enable

namespace Apify
{
    /// <summary>
    /// Tiered price-per-dataset-item pricing, keyed by subscription tier (e.g. `FREE`, `BRONZE`, `SILVER`, `GOLD`,<br/>
    /// `PLATINUM`, `DIAMOND`). The actual price applied to a run is resolved from the user's tier.
    /// </summary>
    public sealed partial class TieredPricingPerDatasetItem
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}