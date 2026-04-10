
#nullable enable

namespace Apify
{
    /// <summary>
    /// Schedules - Introduction. This section describes API endpoints for managing schedules.<br/>
    /// Schedules are used to automatically start your Actors at certain times. Each schedule<br/>
    /// can be associated with a number of Actors and Actor tasks. It is also possible<br/>
    /// to override the settings of each Actor (task) similarly to when invoking the Actor<br/>
    /// (task) using the API.<br/>
    /// For more information, see [Schedules documentation](https://docs.apify.com/platform/schedules).<br/>
    /// Each schedule is assigned actions for it to perform. Actions can be of two types<br/>
    /// - `RUN_ACTOR` and `RUN_ACTOR_TASK`.<br/>
    /// For details, see the documentation of the [Get schedule](#/reference/schedules/schedule-object/get-schedule) endpoint.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface ISchedulesClient : global::System.IDisposable
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