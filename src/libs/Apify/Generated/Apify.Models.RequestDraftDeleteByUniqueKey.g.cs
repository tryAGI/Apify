
#nullable enable

namespace Apify
{
    /// <summary>
    /// A request that should be deleted, identified by its unique key.
    /// </summary>
    public sealed partial class RequestDraftDeleteByUniqueKey
    {
        /// <summary>
        /// A unique identifier assigned to the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// A unique key used for request de-duplication. Requests with the same unique key are considered identical.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uniqueKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UniqueKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestDraftDeleteByUniqueKey" /> class.
        /// </summary>
        /// <param name="uniqueKey">
        /// A unique key used for request de-duplication. Requests with the same unique key are considered identical.
        /// </param>
        /// <param name="id">
        /// A unique identifier assigned to the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestDraftDeleteByUniqueKey(
            string uniqueKey,
            string? id)
        {
            this.Id = id;
            this.UniqueKey = uniqueKey ?? throw new global::System.ArgumentNullException(nameof(uniqueKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestDraftDeleteByUniqueKey" /> class.
        /// </summary>
        public RequestDraftDeleteByUniqueKey()
        {
        }
    }
}