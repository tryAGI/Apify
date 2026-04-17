
#nullable enable

namespace Apify
{
    /// <summary>
    /// Platform usage costs breakdown in USD. Only present if you own the run AND are paying for platform usage (Pay-Per-Usage, Rental, or Pay-Per-Event with usage costs like standby Actors). Not available for standard Pay-Per-Event Actors. Requires authentication token to access.
    /// </summary>
    public sealed partial class RunUsageUsd2
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}