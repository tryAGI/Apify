
#nullable enable

namespace Apify
{
    /// <summary>
    /// A request that should be deleted, identified by its ID.
    /// </summary>
    public sealed partial class RequestDraftDeleteById
    {
        /// <summary>
        /// A unique identifier assigned to the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// A unique key used for request de-duplication. Requests with the same unique key are considered identical.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uniqueKey")]
        public string? UniqueKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestDraftDeleteById" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier assigned to the request.
        /// </param>
        /// <param name="uniqueKey">
        /// A unique key used for request de-duplication. Requests with the same unique key are considered identical.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestDraftDeleteById(
            string id,
            string? uniqueKey)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UniqueKey = uniqueKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestDraftDeleteById" /> class.
        /// </summary>
        public RequestDraftDeleteById()
        {
        }

    }
}