
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
    public sealed partial class ActorsActorVersionsClient : global::Apify.IActorsActorVersionsClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.apify.com/";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Apify.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; } = global::Apify.SourceGenerationContext.Default;


        /// <summary>
        /// Creates a new instance of the ActorsActorVersionsClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public ActorsActorVersionsClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Apify.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Apify.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}