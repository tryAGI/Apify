
#nullable enable

namespace Apify
{
    /// <summary>
    /// A request that should be deleted.
    /// </summary>
    public sealed partial class RequestDraftDelete
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
        public string? UniqueKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestDraftDelete" /> class.
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
        public RequestDraftDelete(
            string? id,
            string? uniqueKey)
        {
            this.Id = id;
            this.UniqueKey = uniqueKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestDraftDelete" /> class.
        /// </summary>
        public RequestDraftDelete()
        {
        }
    }
}