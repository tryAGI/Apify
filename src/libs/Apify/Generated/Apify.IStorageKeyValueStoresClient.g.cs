
#nullable enable

namespace Apify
{
    /// <summary>
    /// Key-value stores - Introduction. This section describes API endpoints to manage Key-value stores.<br/>
    /// Key-value store is a simple storage for saving and reading data records or files.<br/>
    /// Each data record is represented by a unique key and associated with a MIME content type.<br/>
    /// Key-value stores are ideal for saving screenshots, Actor inputs and outputs, web pages,<br/>
    /// PDFs or to persist the state of crawlers.<br/>
    /// For more information, see the [Key-value store documentation](https://docs.apify.com/platform/storage/key-value-store).<br/>
    /// :::note<br/>
    /// Some of the endpoints do not require the authentication token, the calls<br/>
    /// are authenticated using a hard-to-guess ID of the key-value store.<br/>
    /// :::.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IStorageKeyValueStoresClient : global::System.IDisposable
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
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


    }
}