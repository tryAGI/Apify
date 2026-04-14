#nullable enable

namespace Apify
{
    public partial interface IActorsActorRunsClient
    {
        /// <summary>
        /// Get last run<br/>
        /// This is not a single endpoint, but an entire group of endpoints that lets you to<br/>
        /// retrieve and manage the last run of given Actor or any of its default storages.<br/>
        /// All the endpoints require an authentication token.<br/>
        /// The endpoints accept the same HTTP methods and query parameters as<br/>
        /// the respective storage endpoints.<br/>
        /// The base path represents the last Actor run object is:<br/>
        /// `/v2/acts/{actorId}/runs/last{?token,status}`<br/>
        /// Using the `status` query parameter you can ensure to only get a run with a certain status<br/>
        /// (e.g. `status=SUCCEEDED`). The output of this endpoint and other query parameters<br/>
        /// are the same as in the [Run object](#/reference/actors/run-object) endpoint.<br/>
        /// In order to access the default storages of the last Actor run, i.e. log, key-value store, dataset and request queue,<br/>
        /// use the following endpoints:<br/>
        /// * `/v2/acts/{actorId}/runs/last/log{?token,status}`<br/>
        /// * `/v2/acts/{actorId}/runs/last/key-value-store{?token,status}`<br/>
        /// * `/v2/acts/{actorId}/runs/last/dataset{?token,status}`<br/>
        /// * `/v2/acts/{actorId}/runs/last/request-queue{?token,status}`<br/>
        /// These API endpoints have the same usage as the equivalent storage endpoints.<br/>
        /// For example,<br/>
        /// `/v2/acts/{actorId}/runs/last/key-value-store` has the same HTTP method and parameters as the<br/>
        /// [Key-value store object](#/reference/key-value-stores/store-object) endpoint.<br/>
        /// Additionally, each of the above API endpoints supports all sub-endpoints<br/>
        /// of the original one:<br/>
        /// #### Key-value store<br/>
        /// * `/v2/acts/{actorId}/runs/last/key-value-store/keys{?token,status}` [Key collection](#/reference/key-value-stores/key-collection)<br/>
        /// * `/v2/acts/{actorId}/runs/last/key-value-store/records/{recordKey}{?token,status}` [Record](#/reference/key-value-stores/record)<br/>
        /// #### Dataset<br/>
        /// * `/v2/acts/{actorId}/runs/last/dataset/items{?token,status}` [Item collection](#/reference/datasets/item-collection)<br/>
        /// #### Request queue<br/>
        /// * `/v2/acts/{actorId}/runs/last/request-queue/requests{?token,status}` [Request collection](#/reference/request-queues/request-collection)<br/>
        /// * `/v2/acts/{actorId}/runs/last/request-queue/requests/{requestId}{?token,status}` [Request collection](#/reference/request-queues/request)<br/>
        /// * `/v2/acts/{actorId}/runs/last/request-queue/head{?token,status}` [Queue head](#/reference/request-queues/queue-head)<br/>
        /// For example, to download data from a dataset of the last succeeded Actor run in XML format,<br/>
        /// send HTTP GET request to the following URL:<br/>
        /// ```<br/>
        /// https://api.apify.com/v2/acts/{actorId}/runs/last/dataset/items?token={yourApiToken}&amp;format=xml&amp;status=SUCCEEDED<br/>
        /// ```<br/>
        /// In order to save new items to the dataset, send HTTP POST request with JSON payload to the same URL.
        /// </summary>
        /// <param name="actorId">
        /// Example: janedoe~my-actor
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="waitForFinish">
        /// Example: 60
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.RunResponse> ActRunsLastGetAsync(
            string actorId,
            string? status = default,
            double? waitForFinish = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}