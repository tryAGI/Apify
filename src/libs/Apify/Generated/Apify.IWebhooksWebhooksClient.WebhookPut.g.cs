#nullable enable

namespace Apify
{
    public partial interface IWebhooksWebhooksClient
    {
        /// <summary>
        /// Update webhook<br/>
        /// Updates a webhook using values specified by a webhook object passed as JSON<br/>
        /// in the POST payload.<br/>
        /// If the object does not define a specific property, its value will not be<br/>
        /// updated.<br/>
        /// The response is the full webhook object as returned by the<br/>
        /// [Get webhook](#/reference/webhooks/webhook-object/get-webhook) endpoint.<br/>
        /// The request needs to specify the `Content-Type: application/json` HTTP<br/>
        /// header!<br/>
        /// When providing your API authentication token, we recommend using the<br/>
        /// request's `Authorization` header, rather than the URL. ([More<br/>
        /// info](#/introduction/authentication)).
        /// </summary>
        /// <param name="webhookId">
        /// Example: pVJtoTelgYUq4qJOt
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.WebhookResponse> WebhookPutAsync(
            string webhookId,

            global::Apify.WebhookUpdate request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update webhook<br/>
        /// Updates a webhook using values specified by a webhook object passed as JSON<br/>
        /// in the POST payload.<br/>
        /// If the object does not define a specific property, its value will not be<br/>
        /// updated.<br/>
        /// The response is the full webhook object as returned by the<br/>
        /// [Get webhook](#/reference/webhooks/webhook-object/get-webhook) endpoint.<br/>
        /// The request needs to specify the `Content-Type: application/json` HTTP<br/>
        /// header!<br/>
        /// When providing your API authentication token, we recommend using the<br/>
        /// request's `Authorization` header, rather than the URL. ([More<br/>
        /// info](#/introduction/authentication)).
        /// </summary>
        /// <param name="webhookId">
        /// Example: pVJtoTelgYUq4qJOt
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.WebhookResponse>> WebhookPutAsResponseAsync(
            string webhookId,

            global::Apify.WebhookUpdate request,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update webhook<br/>
        /// Updates a webhook using values specified by a webhook object passed as JSON<br/>
        /// in the POST payload.<br/>
        /// If the object does not define a specific property, its value will not be<br/>
        /// updated.<br/>
        /// The response is the full webhook object as returned by the<br/>
        /// [Get webhook](#/reference/webhooks/webhook-object/get-webhook) endpoint.<br/>
        /// The request needs to specify the `Content-Type: application/json` HTTP<br/>
        /// header!<br/>
        /// When providing your API authentication token, we recommend using the<br/>
        /// request's `Authorization` header, rather than the URL. ([More<br/>
        /// info](#/introduction/authentication)).
        /// </summary>
        /// <param name="webhookId">
        /// Example: pVJtoTelgYUq4qJOt
        /// </param>
        /// <param name="isAdHoc"></param>
        /// <param name="eventTypes"></param>
        /// <param name="condition"></param>
        /// <param name="ignoreSslErrors"></param>
        /// <param name="doNotRetry"></param>
        /// <param name="requestUrl"></param>
        /// <param name="payloadTemplate"></param>
        /// <param name="headersTemplate"></param>
        /// <param name="description"></param>
        /// <param name="shouldInterpolateStrings"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.WebhookResponse> WebhookPutAsync(
            string webhookId,
            bool? isAdHoc = default,
            global::System.Collections.Generic.IList<global::Apify.WebhookEventType>? eventTypes = default,
            global::Apify.WebhookCondition? condition = default,
            bool? ignoreSslErrors = default,
            bool? doNotRetry = default,
            string? requestUrl = default,
            string? payloadTemplate = default,
            string? headersTemplate = default,
            string? description = default,
            bool? shouldInterpolateStrings = default,
            global::Apify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}