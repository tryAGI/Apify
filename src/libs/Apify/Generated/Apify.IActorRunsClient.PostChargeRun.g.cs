#nullable enable

namespace Apify
{
    public partial interface IActorRunsClient
    {
        /// <summary>
        /// Charge events in run<br/>
        /// Charge for events in the run of your [pay per event Actor](https://docs.apify.com/platform/actors/running/actors-in-store#pay-per-event).<br/>
        /// The event you are charging for must be one of the configured events in your Actor. If the Actor is not set up as pay per event, or if the event is not configured,<br/>
        /// the endpoint will return an error. The endpoint must be called from the Actor run itself, with the same API token that the run was started with.<br/>
        /// :::info Learn more about pay-per-event pricing<br/>
        /// For more details about pay-per-event (PPE) pricing, refer to our [PPE documentation](/platform/actors/publishing/monetize/pay-per-event).<br/>
        /// :::
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="idempotencyKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.PostChargeRunResponse> PostChargeRunAsync(
            string runId,

            global::Apify.ChargeRunRequest request,
            string? idempotencyKey = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Charge events in run<br/>
        /// Charge for events in the run of your [pay per event Actor](https://docs.apify.com/platform/actors/running/actors-in-store#pay-per-event).<br/>
        /// The event you are charging for must be one of the configured events in your Actor. If the Actor is not set up as pay per event, or if the event is not configured,<br/>
        /// the endpoint will return an error. The endpoint must be called from the Actor run itself, with the same API token that the run was started with.<br/>
        /// :::info Learn more about pay-per-event pricing<br/>
        /// For more details about pay-per-event (PPE) pricing, refer to our [PPE documentation](/platform/actors/publishing/monetize/pay-per-event).<br/>
        /// :::
        /// </summary>
        /// <param name="runId">
        /// Example: 3KH8gEpp4d8uQSe8T
        /// </param>
        /// <param name="idempotencyKey"></param>
        /// <param name="eventName"></param>
        /// <param name="count"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.PostChargeRunResponse> PostChargeRunAsync(
            string runId,
            string eventName,
            int count,
            string? idempotencyKey = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}