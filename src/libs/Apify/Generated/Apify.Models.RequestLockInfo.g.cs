
#nullable enable

namespace Apify
{
    /// <summary>
    /// Information about a request lock.
    /// </summary>
    public sealed partial class RequestLockInfo
    {
        /// <summary>
        /// The timestamp when the lock on this request expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lockExpiresAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LockExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestLockInfo" /> class.
        /// </summary>
        /// <param name="lockExpiresAt">
        /// The timestamp when the lock on this request expires.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestLockInfo(
            global::System.DateTime lockExpiresAt)
        {
            this.LockExpiresAt = lockExpiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestLockInfo" /> class.
        /// </summary>
        public RequestLockInfo()
        {
        }

    }
}