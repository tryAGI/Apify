
#nullable enable

namespace Apify
{
    /// <summary>
    /// The request payload, typically used with POST or PUT requests.
    /// </summary>
    public sealed partial class RequestBasePayload
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}