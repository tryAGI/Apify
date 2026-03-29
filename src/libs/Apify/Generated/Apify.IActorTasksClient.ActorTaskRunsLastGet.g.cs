#nullable enable

namespace Apify
{
    public partial interface IActorTasksClient
    {
        /// <summary>
        /// Get last run<br/>
        /// This is not a single endpoint, but an entire group of endpoints that lets you to<br/>
        /// retrieve and manage the last run of given actor task or any of its default storages.<br/>
        /// All the endpoints require an authentication token.<br/>
        /// The endpoints accept the same HTTP methods and query parameters as<br/>
        /// the respective storage endpoints.<br/>
        /// The base path represents the last actor task run object is:<br/>
        /// `/v2/actor-tasks/{actorTaskId}/runs/last{?token,status}`<br/>
        /// Using the `status` query parameter you can ensure to only get a run with a certain status<br/>
        /// (e.g. `status=SUCCEEDED`). The output of this endpoint and other query parameters<br/>
        /// are the same as in the [Run object](/api/v2/actor-run-get) endpoint.<br/>
        /// In order to access the default storages of the last actor task run, i.e. log, key-value store, dataset and request queue,<br/>
        /// use the following endpoints:<br/>
        /// * `/v2/actor-tasks/{actorTaskId}/runs/last/log{?token,status}`<br/>
        /// * `/v2/actor-tasks/{actorTaskId}/runs/last/key-value-store{?token,status}`<br/>
        /// * `/v2/actor-tasks/{actorTaskId}/runs/last/dataset{?token,status}`<br/>
        /// * `/v2/actor-tasks/{actorTaskId}/runs/last/request-queue{?token,status}`<br/>
        /// These API endpoints have the same usage as the equivalent storage endpoints.<br/>
        /// For example,<br/>
        /// `/v2/actor-tasks/{actorTaskId}/runs/last/key-value-store` has the same HTTP method and parameters as the<br/>
        /// [Key-value store object](/api/v2/storage-key-value-stores) endpoint.<br/>
        /// Additionally, each of the above API endpoints supports all sub-endpoints<br/>
        /// of the original one:<br/>
        /// ##### Storage endpoints<br/>
        /// * [Dataset - introduction](/api/v2/storage-datasets)<br/>
        /// * [Key-value store - introduction](/api/v2/storage-key-value-stores)<br/>
        /// * [Request queue - introduction](/api/v2/storage-request-queues)<br/>
        /// For example, to download data from a dataset of the last succeeded actor task run in XML format,<br/>
        /// send HTTP GET request to the following URL:<br/>
        /// ```<br/>
        /// https://api.apify.com/v2/actor-tasks/{actorTaskId}/runs/last/dataset/items?token={yourApiToken}&amp;format=xml&amp;status=SUCCEEDED<br/>
        /// ```<br/>
        /// In order to save new items to the dataset, send HTTP POST request with JSON payload to the same URL.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="status">
        /// Example: SUCCEEDED
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.ActorTaskRunsLastGetResponse> ActorTaskRunsLastGetAsync(
            string actorTaskId,
            string? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}