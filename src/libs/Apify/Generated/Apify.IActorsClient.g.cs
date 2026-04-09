
#nullable enable

namespace Apify
{
    /// <summary>
    /// Actors - Introduction. The API endpoints in this section allow you to manage Apify Actors. For more details about Actors, refer to the [Actor documentation](https://docs.apify.com/platform/actors).<br/>
    /// For API endpoints that require the `actorId` parameter to identify an Actor, you can provide either:<br/>
    /// - The Actor ID (e.g., `HG7ML7M8z78YcAPEB`), or<br/>
    /// - A tilde-separated combination of the Actor owner's username and the Actor name (e.g., `janedoe~my-actor`).<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IActorsClient : global::System.IDisposable
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