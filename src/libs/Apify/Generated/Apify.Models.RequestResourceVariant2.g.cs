
#nullable enable

namespace Apify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RequestResourceVariant2
    {
        /// <summary>
        /// A unique identifier assigned to the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The timestamp when the lock on this request expires. Only present while the request is locked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lockExpiresAt")]
        public global::System.DateTime? LockExpiresAt { get; set; }

        /// <summary>
        /// Key of the client that last locked the request. It is set when the request is locked and removed only by<br/>
        /// an explicit unlock or by an update of the request, so it can still be present after the lock has expired.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lockByClient")]
        public string? LockByClient { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestResourceVariant2" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier assigned to the request.
        /// </param>
        /// <param name="lockExpiresAt">
        /// The timestamp when the lock on this request expires. Only present while the request is locked.
        /// </param>
        /// <param name="lockByClient">
        /// Key of the client that last locked the request. It is set when the request is locked and removed only by<br/>
        /// an explicit unlock or by an update of the request, so it can still be present after the lock has expired.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestResourceVariant2(
            string? id,
            global::System.DateTime? lockExpiresAt,
            string? lockByClient)
        {
            this.Id = id;
            this.LockExpiresAt = lockExpiresAt;
            this.LockByClient = lockByClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestResourceVariant2" /> class.
        /// </summary>
        public RequestResourceVariant2()
        {
        }

    }
}