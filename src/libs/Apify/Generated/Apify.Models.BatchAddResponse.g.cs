
#nullable enable

namespace Apify
{
    /// <summary>
    /// Response containing the result of a batch add operation.<br/>
    /// Example: {"data":{"processedRequests":[{"requestId":"YiKoxjkaS9gjGTqhF","uniqueKey":"http://example.com","wasAlreadyPresent":true,"wasAlreadyHandled":false}],"unprocessedRequests":[{"uniqueKey":"http://example.com/2","url":"http://example.com/2","method":"GET"}]}}
    /// </summary>
    public sealed partial class BatchAddResponse
    {
        /// <summary>
        /// Result of a batch add operation containing successfully processed and failed requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.BatchAddResult Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchAddResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Result of a batch add operation containing successfully processed and failed requests.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchAddResponse(
            global::Apify.BatchAddResult data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchAddResponse" /> class.
        /// </summary>
        public BatchAddResponse()
        {
        }

    }
}