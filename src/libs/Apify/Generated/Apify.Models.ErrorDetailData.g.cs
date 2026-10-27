
#nullable enable

namespace Apify
{
    /// <summary>
    /// Additional machine-readable details about the error. Present only for some error types.
    /// </summary>
    public sealed partial class ErrorDetailData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}