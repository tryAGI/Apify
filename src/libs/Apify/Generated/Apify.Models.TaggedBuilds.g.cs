
#nullable enable

namespace Apify
{
    /// <summary>
    /// A dictionary mapping build tag names (e.g., "latest", "beta") to their build information.<br/>
    /// Example: {"latest":{"buildId":"z2EryhbfhgSyqj6Hn","buildNumber":"0.0.2","finishedAt":"2019-06-10T11:15:49.286Z"},"beta":{"buildId":"abc123def456","buildNumber":"1.0.5","finishedAt":"2019-07-15T14:30:00.000Z"}}
    /// </summary>
    public sealed partial class TaggedBuilds
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}