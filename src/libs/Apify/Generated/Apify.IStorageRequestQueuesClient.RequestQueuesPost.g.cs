#nullable enable

namespace Apify
{
    public partial interface IStorageRequestQueuesClient
    {
        /// <summary>
        /// Create request queue<br/>
        /// Creates a request queue and returns its object.<br/>
        /// Keep in mind that requests stored under unnamed queue follows [data<br/>
        /// retention period](https://docs.apify.com/platform/storage#data-retention).<br/>
        /// It creates a queue of given name if the parameter name is used. If a queue<br/>
        /// with the given name already exists then the endpoint returns<br/>
        /// its object.
        /// </summary>
        /// <param name="name">
        /// Example: example-com
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.RequestQueueResponse> RequestQueuesPostAsync(
            string? name = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create request queue<br/>
        /// Creates a request queue and returns its object.<br/>
        /// Keep in mind that requests stored under unnamed queue follows [data<br/>
        /// retention period](https://docs.apify.com/platform/storage#data-retention).<br/>
        /// It creates a queue of given name if the parameter name is used. If a queue<br/>
        /// with the given name already exists then the endpoint returns<br/>
        /// its object.
        /// </summary>
        /// <param name="name">
        /// Example: example-com
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.RequestQueueResponse>> RequestQueuesPostAsResponseAsync(
            string? name = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}