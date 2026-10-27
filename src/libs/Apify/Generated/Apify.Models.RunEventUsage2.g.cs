
#nullable enable

namespace Apify
{
    /// <summary>
    /// Cost breakdown of the pay-per-event charges in USD, keyed by event type. Present only for pay-per-event runs, and not when the run was started by the Actor's owner.
    /// </summary>
    public sealed partial class RunEventUsage2
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}