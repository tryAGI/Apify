
#nullable enable

namespace Apify
{
    /// <summary>
    /// Tools - Introduction. The API endpoints described in this section provide utility tools for encoding,<br/>
    /// signing, and verifying data, as well as inspecting HTTP request details.<br/>
    /// - **Browser info** (`/v2/browser-info`) - Returns details about the incoming HTTP request,<br/>
    ///   including the client IP address, country code, and headers. Accepts any HTTP method<br/>
    ///   (GET, POST, PUT, DELETE) so you can use it to test proxy behavior and verify that<br/>
    ///   client IP addresses are anonymized correctly.<br/>
    /// - **Encode and sign** (`/v2/tools/encode-and-sign`) - Encodes and signs a JSON object,<br/>
    ///   tying it to the authenticated user's identity.<br/>
    /// - **Decode and verify** (`/v2/tools/decode-and-verify`) - Decodes and verifies a value<br/>
    ///   previously created by the encode-and-sign endpoint.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IToolsClient : global::System.IDisposable
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