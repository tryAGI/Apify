
#nullable enable

namespace Apify
{
    /// <summary>
    /// A map of charged event types to the number of their charges that have already been accounted for billing. Present only for pay-per-event Actors.<br/>
    /// Example: {"actor-start":1,"page-crawled":150}
    /// </summary>
    public sealed partial class RunAccountedChargedEventCounts
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}