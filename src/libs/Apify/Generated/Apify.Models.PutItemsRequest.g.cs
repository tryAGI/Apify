
#nullable enable

namespace Apify
{
    /// <summary>
    /// The request body containing the item(s) to add to the dataset. Can be a single<br/>
    /// object or an array of objects. Each object represents one dataset item.<br/>
    /// Example: {"title":"Example Item","url":"https://example.com","price":19.99}
    /// </summary>
    public sealed partial class PutItemsRequest
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}