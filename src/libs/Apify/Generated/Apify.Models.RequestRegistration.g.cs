
#nullable enable

namespace Apify
{
    /// <summary>
    /// Result of registering a request in the request queue, either by adding a new request or updating an existing one.
    /// </summary>
    public sealed partial class RequestRegistration
    {
        /// <summary>
        /// A unique identifier assigned to the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Indicates whether a request with the same unique key already existed in the request queue. If true, no new request was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wasAlreadyPresent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool WasAlreadyPresent { get; set; }

        /// <summary>
        /// Indicates whether a request with the same unique key has already been processed by the request queue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wasAlreadyHandled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool WasAlreadyHandled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestRegistration" /> class.
        /// </summary>
        /// <param name="requestId">
        /// A unique identifier assigned to the request.
        /// </param>
        /// <param name="wasAlreadyPresent">
        /// Indicates whether a request with the same unique key already existed in the request queue. If true, no new request was created.
        /// </param>
        /// <param name="wasAlreadyHandled">
        /// Indicates whether a request with the same unique key has already been processed by the request queue.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestRegistration(
            string requestId,
            bool wasAlreadyPresent,
            bool wasAlreadyHandled)
        {
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.WasAlreadyPresent = wasAlreadyPresent;
            this.WasAlreadyHandled = wasAlreadyHandled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestRegistration" /> class.
        /// </summary>
        public RequestRegistration()
        {
        }

    }
}