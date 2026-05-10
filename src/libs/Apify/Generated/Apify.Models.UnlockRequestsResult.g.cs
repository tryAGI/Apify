
#nullable enable

namespace Apify
{
    /// <summary>
    /// Result of unlocking requests in the request queue.
    /// </summary>
    public sealed partial class UnlockRequestsResult
    {
        /// <summary>
        /// Number of requests that were successfully unlocked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unlockedCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UnlockedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnlockRequestsResult" /> class.
        /// </summary>
        /// <param name="unlockedCount">
        /// Number of requests that were successfully unlocked.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnlockRequestsResult(
            int unlockedCount)
        {
            this.UnlockedCount = unlockedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnlockRequestsResult" /> class.
        /// </summary>
        public UnlockRequestsResult()
        {
        }

    }
}