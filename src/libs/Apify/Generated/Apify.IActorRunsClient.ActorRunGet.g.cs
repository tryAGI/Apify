#nullable enable

namespace Apify
{
    public partial interface IActorRunsClient
    {
        /// <summary>
        /// Get run<br/>
        /// This is not a single endpoint, but an entire group of endpoints that lets<br/>
        /// you retrieve the run or any of its default storages.<br/>
        /// The endpoints accept the same HTTP methods and query parameters as<br/>
        /// the respective storage endpoints.<br/>
        /// The base path that represents the Actor run object is:<br/>
        /// `/v2/actor-runs/{runId}{?token}`<br/>
        /// In order to access the default storages of the Actor run, i.e. log,<br/>
        /// key-value store, dataset and request queue, use the following endpoints:<br/>
        /// * `/v2/actor-runs/{runId}/log{?token}`<br/>
        /// * `/v2/actor-runs/{runId}/key-value-store{?token}`<br/>
        /// * `/v2/actor-runs/{runId}/dataset{?token}`<br/>
        /// * `/v2/actor-runs/{runId}/request-queue{?token}`<br/>
        /// These API endpoints have the same usage as the equivalent storage endpoints.<br/>
        /// For example, `/v2/actor-runs/{runId}/key-value-store` has the same HTTP method and<br/>
        /// parameters as the [Key-value store object](#/reference/key-value-stores/store-object) endpoint.<br/>
        /// Additionally, each of the above API endpoints supports all sub-endpoints<br/>
        /// of the original one:<br/>
        /// #### Log<br/>
        /// * `/v2/actor-runs/{runId}/log` [Log](#/reference/logs)<br/>
        /// #### Key-value store<br/>
        /// * `/v2/actor-runs/{runId}/key-value-store/keys{?token}` [Key<br/>
        /// collection](#/reference/key-value-stores/key-collection)<br/>
        /// * `/v2/actor-runs/{runId}/key-value-store/records/{recordKey}{?token}`<br/>
        /// [Record](#/reference/key-value-stores/record)<br/>
        /// #### Dataset<br/>
        /// * `/v2/actor-runs/{runId}/dataset/items{?token}` [Item<br/>
        /// collection](#/reference/datasets/item-collection)<br/>
        /// #### Request queue<br/>
        /// * `/v2/actor-runs/{runId}/request-queue/requests{?token}` [Request<br/>
        /// collection](#/reference/request-queues/request-collection)<br/>
        /// * `/v2/actor-runs/{runId}/request-queue/requests/{requestId}{?token}`<br/>
        /// [Request collection](#/reference/request-queues/request)<br/>
        /// * `/v2/actor-runs/{runId}/request-queue/head{?token}` [Queue<br/>
        /// head](#/reference/request-queues/queue-head)<br/>
        /// For example, to download data from a dataset of the Actor run in XML format,<br/>
        /// send HTTP GET request to the following URL:<br/>
        /// ```<br/>
        /// https://api.apify.com/v2/actor-runs/{runId}/dataset/items?format=xml<br/>
        /// ```<br/>
        /// In order to save new items to the dataset, send HTTP POST request with JSON<br/>
        /// payload to the same URL.<br/>
        /// Gets an object that contains all the details about a<br/>
        /// specific run of an Actor.<br/>
        /// By passing the optional `waitForFinish` parameter the API endpoint will synchronously wait<br/>
        /// for the run to finish. This is useful to avoid periodic polling when waiting for Actor run to complete.<br/>
        /// This endpoint does not require the authentication token. Instead, calls are authenticated using a hard-to-guess ID of the run. However,<br/>
        /// if you access the endpoint without the token, certain attributes, such as `usageUsd` and `usageTotalUsd`, will be hidden.
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="waitForFinish">
        /// Example: 60
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.RunResponse> ActorRunGetAsync(
            string runId,
            double? waitForFinish = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}