
#nullable enable

namespace Apify
{
    /// <summary>
    /// Requests - Introduction. This section describes API endpoints to create, manage, and delete requests within request queues.<br/>
    /// Request queue is a storage for a queue of HTTP URLs to crawl, which is typically<br/>
    /// used for deep crawling of websites where you<br/>
    /// start with several URLs and then recursively follow links to other pages.<br/>
    /// The storage supports both breadth-first and depth-first crawling orders.<br/>
    /// For more information, see the [Request queue documentation](https://docs.apify.com/platform/storage/request-queue).<br/>
    /// :::note<br/>
    /// Some of the endpoints do not require the authentication token, the calls<br/>
    /// are authenticated using the hard-to-guess ID of the queue.<br/>
    /// :::.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IStorageRequestQueuesRequestsClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Apify.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Apify.AutoSDKClientOptions Options { get; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


    }
}