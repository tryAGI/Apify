
#nullable enable

namespace Apify
{
    /// <summary>
    /// Actor tasks - Introduction. The API endpoints described in this section enable you to create, manage, delete, and run Apify Actor tasks.<br/>
    /// For more information, see the [Actor tasts documentation](https://docs.apify.com/platform/actors/running/tasks).<br/>
    /// :::note<br/>
    /// For all the API endpoints that accept the `actorTaskId` parameter to<br/>
    /// specify a task, you can pass either the task ID (e.g. `HG7ML7M8z78YcAPEB`) or a tilde-separated<br/>
    /// username of the task's owner and the task's name (e.g. `janedoe~my-task`).<br/>
    /// :::<br/>
    /// Some of the API endpoints return run objects. If any such run object<br/>
    /// contains usage in dollars, your effective unit pricing at the time of query<br/>
    /// has been used for computation of this dollar equivalent, and hence it should be<br/>
    /// used only for informative purposes.<br/>
    /// You can learn more about platform usage in the [documentation](https://docs.apify.com/platform/actors/running/usage-and-resources#usage).<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IActorTasksClient : global::System.IDisposable
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