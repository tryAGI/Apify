
#nullable enable

namespace Apify
{
    /// <summary>
    /// A dictionary that maps tag names to specific builds. For details, see [Update build tags](#update-build-tags).<br/>
    /// Example: {"latest":{"buildId":"z2EryhbfhgSyqj6Hn"},"beta":null}
    /// </summary>
    public sealed partial class UpdateActorRequestTaggedBuilds
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}