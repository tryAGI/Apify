
#nullable enable

namespace Apify
{
    /// <summary>
    /// The request body contains the value to store in the record. The content type<br/>
    /// should be specified in the Content-Type header.<br/>
    /// Example: {"message":"Hello, world!","count":42}
    /// </summary>
    public sealed partial class PutRecordRequest
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}