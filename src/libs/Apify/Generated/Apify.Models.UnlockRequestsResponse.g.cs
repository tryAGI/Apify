
#nullable enable

namespace Apify
{
    /// <summary>
    /// Response containing the result of unlocking requests.
    /// </summary>
    public sealed partial class UnlockRequestsResponse
    {
        /// <summary>
        /// Result of unlocking requests in the request queue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Apify.UnlockRequestsResult Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnlockRequestsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Result of unlocking requests in the request queue.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnlockRequestsResponse(
            global::Apify.UnlockRequestsResult data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnlockRequestsResponse" /> class.
        /// </summary>
        public UnlockRequestsResponse()
        {
        }
    }
}