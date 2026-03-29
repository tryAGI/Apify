
#nullable enable

namespace Apify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestBase
    {
        /// <summary>
        /// A unique key used for request de-duplication. Requests with the same unique key are considered identical.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uniqueKey")]
        public string? UniqueKey { get; set; }

        /// <summary>
        /// The URL of the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

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
        /// The final URL that was loaded, after redirects (if any).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loadedUrl")]
        public string? LoadedUrl { get; set; }

        /// <summary>
        /// The request payload, typically used with POST or PUT requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public object? Payload { get; set; }

        /// <summary>
        /// HTTP headers sent with the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// Custom user data attached to the request. Can contain arbitrary fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userData")]
        public global::Apify.RequestUserData? UserData { get; set; }

        /// <summary>
        /// Indicates whether the request should not be retried if processing fails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("noRetry")]
        public bool? NoRetry { get; set; }

        /// <summary>
        /// Error messages recorded from failed processing attempts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorMessages")]
        public global::System.Collections.Generic.IList<string>? ErrorMessages { get; set; }

        /// <summary>
        /// The timestamp when the request was marked as handled, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handledAt")]
        public global::System.DateTime? HandledAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestBase" /> class.
        /// </summary>
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
        /// <param name="loadedUrl">
        /// The final URL that was loaded, after redirects (if any).
        /// </param>
        /// <param name="payload">
        /// The request payload, typically used with POST or PUT requests.
        /// </param>
        /// <param name="headers">
        /// HTTP headers sent with the request.
        /// </param>
        /// <param name="userData">
        /// Custom user data attached to the request. Can contain arbitrary fields.
        /// </param>
        /// <param name="noRetry">
        /// Indicates whether the request should not be retried if processing fails.
        /// </param>
        /// <param name="errorMessages">
        /// Error messages recorded from failed processing attempts.
        /// </param>
        /// <param name="handledAt">
        /// The timestamp when the request was marked as handled, if applicable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestBase(
            string? uniqueKey,
            string? url,
            global::Apify.HttpMethod? method,
            int? retryCount,
            string? loadedUrl,
            object? payload,
            object? headers,
            global::Apify.RequestUserData? userData,
            bool? noRetry,
            global::System.Collections.Generic.IList<string>? errorMessages,
            global::System.DateTime? handledAt)
        {
            this.UniqueKey = uniqueKey;
            this.Url = url;
            this.Method = method;
            this.RetryCount = retryCount;
            this.LoadedUrl = loadedUrl;
            this.Payload = payload;
            this.Headers = headers;
            this.UserData = userData;
            this.NoRetry = noRetry;
            this.ErrorMessages = errorMessages;
            this.HandledAt = handledAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestBase" /> class.
        /// </summary>
        public RequestBase()
        {
        }
    }
}