
#nullable enable

namespace Apify
{
    /// <summary>
    /// A map of charged event types to their counts. The keys are event type identifiers defined by the Actor's pricing model (pay-per-event), and the values are the number of times each event was charged during this run.<br/>
    /// Example: {"actor-start":1,"page-crawled":150,"data-extracted":75}
    /// </summary>
    public sealed partial class RunChargedEventCounts
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}