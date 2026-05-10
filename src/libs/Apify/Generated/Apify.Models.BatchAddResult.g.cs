
#nullable enable

namespace Apify
{
    /// <summary>
    /// Result of a batch add operation containing successfully processed and failed requests.
    /// </summary>
    public sealed partial class BatchAddResult
    {
        /// <summary>
        /// Requests that were successfully added to the request queue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processedRequests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Apify.AddedRequest> ProcessedRequests { get; set; }

        /// <summary>
        /// Requests that failed to be added and can be retried.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unprocessedRequests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Apify.RequestDraft> UnprocessedRequests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchAddResult" /> class.
        /// </summary>
        /// <param name="processedRequests">
        /// Requests that were successfully added to the request queue.
        /// </param>
        /// <param name="unprocessedRequests">
        /// Requests that failed to be added and can be retried.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchAddResult(
            global::System.Collections.Generic.IList<global::Apify.AddedRequest> processedRequests,
            global::System.Collections.Generic.IList<global::Apify.RequestDraft> unprocessedRequests)
        {
            this.ProcessedRequests = processedRequests ?? throw new global::System.ArgumentNullException(nameof(processedRequests));
            this.UnprocessedRequests = unprocessedRequests ?? throw new global::System.ArgumentNullException(nameof(unprocessedRequests));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchAddResult" /> class.
        /// </summary>
        public BatchAddResult()
        {
        }

    }
}