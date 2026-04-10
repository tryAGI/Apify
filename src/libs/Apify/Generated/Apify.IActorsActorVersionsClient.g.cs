
#nullable enable

namespace Apify
{
    /// <summary>
    /// Actor versions - Introduction. The API endpoints in this section allow you to manage your Apify Actors versions.<br/>
    /// - The version object contains the source code of a specific version of an Actor.<br/>
    /// - The `sourceType` property indicates where the source code is hosted, and based<br/>
    /// on its value the Version object has the following additional property:<br/>
    /// | **Value** | **Description**  |<br/>
    /// |---|---|<br/>
    /// | `"SOURCE_FILES"`   | Source code is comprised of multiple files specified in the `sourceFiles` array. Each item of the array is an object with the following fields:&lt;br/&gt; - `name`: File path and name&lt;br/&gt; - `format`: Format of the content, can be either `"TEXT"` or `"BASE64"`&lt;br/&gt; - `content`: File content&lt;br/&gt;&lt;br/&gt;Source files can be shown and edited in the Apify Console's Web IDE. |<br/>
    /// | `"GIT_REPO"` | Source code is cloned from a Git repository, whose URL is specified in the `gitRepoUrl` field. |<br/>
    /// | `"TARBALL"` | Source code is downloaded using a tarball or Zip file from a URL specified in the `tarballUrl` field.  |<br/>
    /// |`"GITHUB_GIST"`| Source code is taken from a GitHub Gist, whose URL is specified in the `gitHubGistUrl` field. |<br/>
    /// For more information about source code and Actor versions, check out [Source code](https://docs.apify.com/platform/actors/development/actor-definition/source-code)<br/>
    /// in Actors documentation.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IActorsActorVersionsClient : global::System.IDisposable
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