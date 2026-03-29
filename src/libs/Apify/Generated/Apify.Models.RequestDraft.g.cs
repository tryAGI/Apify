
#nullable enable

namespace Apify
{
    /// <summary>
    /// A request that failed to be processed during a request queue operation and can be retried.
    /// </summary>
    public sealed partial class RequestDraft
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
        /// The URL of the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Apify.JsonConverters.HttpMethodJsonConverter))]
        public global::Apify.HttpMethod? Method { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestDraft" /> class.
        /// </summary>
        /// <param name="uniqueKey">
        /// A unique key used for request de-duplication. Requests with the same unique key are considered identical.
        /// </param>
        /// <param name="url">
        /// The URL of the request.
        /// </param>
        /// <param name="id">
        /// A unique identifier assigned to the request.
        /// </param>
        /// <param name="method"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestDraft(
            string uniqueKey,
            string url,
            string? id,
            global::Apify.HttpMethod? method)
        {
            this.Id = id;
            this.UniqueKey = uniqueKey ?? throw new global::System.ArgumentNullException(nameof(uniqueKey));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Method = method;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestDraft" /> class.
        /// </summary>
        public RequestDraft()
        {
        }
    }
}