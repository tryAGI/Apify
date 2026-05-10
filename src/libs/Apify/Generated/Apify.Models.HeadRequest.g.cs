
#nullable enable

namespace Apify
{
    /// <summary>
    /// A request from the request queue head without lock information.
    /// </summary>
    public sealed partial class HeadRequest
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
        /// The number of times this request has been retried.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retryCount")]
        public int? RetryCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeadRequest" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier assigned to the request.
        /// </param>
        /// <param name="uniqueKey">
        /// A unique key used for request de-duplication. Requests with the same unique key are considered identical.
        /// </param>
        /// <param name="url">
        /// The URL of the request.
        /// </param>
        /// <param name="method"></param>
        /// <param name="retryCount">
        /// The number of times this request has been retried.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HeadRequest(
            string id,
            string uniqueKey,
            string url,
            global::Apify.HttpMethod? method,
            int? retryCount)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UniqueKey = uniqueKey ?? throw new global::System.ArgumentNullException(nameof(uniqueKey));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Method = method;
            this.RetryCount = retryCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeadRequest" /> class.
        /// </summary>
        public HeadRequest()
        {
        }

    }
}