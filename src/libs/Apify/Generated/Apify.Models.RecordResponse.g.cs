
#nullable enable

namespace Apify
{
    /// <summary>
    /// The response body contains the value of the record. The content type of the response<br/>
    /// is determined by the Content-Type header stored with the record.<br/>
    /// Example: {"message":"Hello, world!","count":42}
    /// </summary>
    public sealed partial class RecordResponse
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}