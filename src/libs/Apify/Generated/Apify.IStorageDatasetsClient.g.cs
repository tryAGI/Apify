
#nullable enable

namespace Apify
{
    /// <summary>
    /// Datasets - Introduction. This section describes API endpoints to manage Datasets.<br/>
    /// Dataset is a storage for structured data, where each record stored has the same attributes,<br/>
    /// such as online store products or real estate offers. You can imagine it as a table,<br/>
    /// where each object is a row and its attributes are columns. Dataset is an append-only<br/>
    /// storage - you can only add new records to it but you cannot modify or remove existing<br/>
    /// records. Typically it is used to store crawling results.<br/>
    /// For more information, see the [Datasets documentation](https://docs.apify.com/platform/storage/dataset).<br/>
    /// :::note<br/>
    /// Some of the endpoints do not require the authentication token, the calls<br/>
    /// are authenticated using the hard-to-guess ID of the dataset.<br/>
    /// :::.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IStorageDatasetsClient : global::System.IDisposable
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