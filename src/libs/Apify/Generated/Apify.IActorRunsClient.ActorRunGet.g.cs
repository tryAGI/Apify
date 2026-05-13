#nullable enable

namespace Apify
{
    public partial interface IActorRunsClient
    {
        /// <summary>
        /// Get run<br/>
        /// This is not a single endpoint, but an entire group of endpoints that lets<br/>
        /// you retrieve the run or any of its default storages.<br/>
        /// ##### Convenience endpoints for Actor run default storages<br/>
        /// * [Dataset](/api/v2/default-dataset)<br/>
        /// * [Key-value store](/api/v2/default-key-value-store)<br/>
        /// * [Request queue](/api/v2/default-request-queue)<br/>
        /// Gets an object that contains all the details about a<br/>
        /// specific run of an Actor.<br/>
        /// By passing the optional `waitForFinish` parameter the API endpoint will synchronously wait<br/>
        /// for the run to finish. This is useful to avoid periodic polling when waiting for Actor run to complete.<br/>
        /// Note that the first response after completion can still show preliminary `stats`, costs, and event counts.<br/>
        /// For stable figures, wait about 10 seconds and call the endpoint again.<br/>
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
        /// <summary>
        /// Get run<br/>
        /// This is not a single endpoint, but an entire group of endpoints that lets<br/>
        /// you retrieve the run or any of its default storages.<br/>
        /// ##### Convenience endpoints for Actor run default storages<br/>
        /// * [Dataset](/api/v2/default-dataset)<br/>
        /// * [Key-value store](/api/v2/default-key-value-store)<br/>
        /// * [Request queue](/api/v2/default-request-queue)<br/>
        /// Gets an object that contains all the details about a<br/>
        /// specific run of an Actor.<br/>
        /// By passing the optional `waitForFinish` parameter the API endpoint will synchronously wait<br/>
        /// for the run to finish. This is useful to avoid periodic polling when waiting for Actor run to complete.<br/>
        /// Note that the first response after completion can still show preliminary `stats`, costs, and event counts.<br/>
        /// For stable figures, wait about 10 seconds and call the endpoint again.<br/>
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
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.RunResponse>> ActorRunGetAsResponseAsync(
            string runId,
            double? waitForFinish = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}