
#nullable enable

namespace Apify
{
    /// <summary>
    /// Tiered price-per-event pricing for a single charge event, keyed by subscription tier (e.g. `FREE`, `BRONZE`,<br/>
    /// `SILVER`, `GOLD`, `PLATINUM`, `DIAMOND`). The actual price applied is resolved from the user's tier.
    /// </summary>
    public sealed partial class TieredPricingPerEvent
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}