
#nullable enable

namespace Apify
{
    /// <summary>
    /// Example: {"data":{"items":[{"key":"second-key","size":36,"recordPublicUrl":"https://api.apify.com/v2/key-value-stores/WkzbQMuFYuamGv3YF/records/second-key?signature=abc123"},{"key":"third-key","size":128,"recordPublicUrl":"https://api.apify.com/v2/key-value-stores/WkzbQMuFYuamGv3YF/records/third-key?signature=abc123"}],"count":2,"limit":2,"exclusiveStartKey":"some-key","isTruncated":true,"nextExclusiveStartKey":"third-key"}}
    /// </summary>
    public sealed partial class ListOfKeysResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.ListOfKeys Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfKeysResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListOfKeysResponse(
            global::Apify.ListOfKeys data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfKeysResponse" /> class.
        /// </summary>
        public ListOfKeysResponse()
        {
        }
    }
}