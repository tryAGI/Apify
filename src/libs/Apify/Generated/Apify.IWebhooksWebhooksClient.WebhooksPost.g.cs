#nullable enable

namespace Apify
{
    public partial interface IWebhooksWebhooksClient
    {
        /// <summary>
        /// Create webhook<br/>
        /// Creates a new webhook with settings provided by the webhook object passed as<br/>
        /// JSON in the payload.<br/>
        /// The response is the created webhook object.<br/>
        /// To avoid duplicating a webhook, use the `idempotencyKey` parameter in the<br/>
        /// request body.<br/>
        /// Multiple calls to create a webhook with the same `idempotencyKey` will only<br/>
        /// create the webhook with the first call and return the existing webhook on<br/>
        /// subsequent calls.<br/>
        /// Idempotency keys must be unique, so use a UUID or another random string with<br/>
        /// enough entropy.<br/>
        /// To assign the new webhook to an Actor or task, the request body must contain<br/>
        /// `requestUrl`, `eventTypes`, and `condition` properties.<br/>
        /// * `requestUrl` is the webhook's target URL, to which data is sent as a POST<br/>
        /// request with a JSON payload.<br/>
        /// * `eventTypes` is a list of events that will trigger the webhook, e.g. when<br/>
        /// the Actor run succeeds.<br/>
        /// * `condition` should be an object containing the ID of the Actor or task to<br/>
        /// which the webhook will be assigned.<br/>
        /// * `payloadTemplate` is a JSON-like string, whose syntax is extended with the<br/>
        /// use of variables.<br/>
        /// * `headersTemplate` is a JSON-like string, whose syntax is extended with the<br/>
        /// use of variables. Following values will be re-written to defaults: "host",<br/>
        /// "Content-Type", "X-Apify-Webhook", "X-Apify-Webhook-Dispatch-Id",<br/>
        /// "X-Apify-Request-Origin"<br/>
        /// * `description` is an optional string.<br/>
        /// * `shouldInterpolateStrings` is a boolean indicating whether to interpolate<br/>
        /// variables contained inside strings in the `payloadTemplate`<br/>
        /// ```<br/>
        ///     "isAdHoc" : false,<br/>
        ///     "requestUrl" : "https://example.com",<br/>
        ///     "eventTypes" : [<br/>
        ///         "ACTOR.RUN.SUCCEEDED",<br/>
        ///         "ACTOR.RUN.ABORTED"<br/>
        ///     ],<br/>
        ///     "condition" : {<br/>
        ///         "actorId": "5sTMwDQywwsLzKRRh",<br/>
        ///         "actorTaskId" : "W9bs9JE9v7wprjAnJ"<br/>
        ///     },<br/>
        ///     "payloadTemplate": "",<br/>
        ///     "headersTemplate": "",<br/>
        ///     "description": "my awesome webhook",<br/>
        ///     "shouldInterpolateStrings": false,<br/>
        /// ```<br/>
        /// **Important**: The request must specify the `Content-Type: application/json`<br/>
        /// HTTP header.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.WebhookResponse> WebhooksPostAsync(

            global::Apify.WebhookCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create webhook<br/>
        /// Creates a new webhook with settings provided by the webhook object passed as<br/>
        /// JSON in the payload.<br/>
        /// The response is the created webhook object.<br/>
        /// To avoid duplicating a webhook, use the `idempotencyKey` parameter in the<br/>
        /// request body.<br/>
        /// Multiple calls to create a webhook with the same `idempotencyKey` will only<br/>
        /// create the webhook with the first call and return the existing webhook on<br/>
        /// subsequent calls.<br/>
        /// Idempotency keys must be unique, so use a UUID or another random string with<br/>
        /// enough entropy.<br/>
        /// To assign the new webhook to an Actor or task, the request body must contain<br/>
        /// `requestUrl`, `eventTypes`, and `condition` properties.<br/>
        /// * `requestUrl` is the webhook's target URL, to which data is sent as a POST<br/>
        /// request with a JSON payload.<br/>
        /// * `eventTypes` is a list of events that will trigger the webhook, e.g. when<br/>
        /// the Actor run succeeds.<br/>
        /// * `condition` should be an object containing the ID of the Actor or task to<br/>
        /// which the webhook will be assigned.<br/>
        /// * `payloadTemplate` is a JSON-like string, whose syntax is extended with the<br/>
        /// use of variables.<br/>
        /// * `headersTemplate` is a JSON-like string, whose syntax is extended with the<br/>
        /// use of variables. Following values will be re-written to defaults: "host",<br/>
        /// "Content-Type", "X-Apify-Webhook", "X-Apify-Webhook-Dispatch-Id",<br/>
        /// "X-Apify-Request-Origin"<br/>
        /// * `description` is an optional string.<br/>
        /// * `shouldInterpolateStrings` is a boolean indicating whether to interpolate<br/>
        /// variables contained inside strings in the `payloadTemplate`<br/>
        /// ```<br/>
        ///     "isAdHoc" : false,<br/>
        ///     "requestUrl" : "https://example.com",<br/>
        ///     "eventTypes" : [<br/>
        ///         "ACTOR.RUN.SUCCEEDED",<br/>
        ///         "ACTOR.RUN.ABORTED"<br/>
        ///     ],<br/>
        ///     "condition" : {<br/>
        ///         "actorId": "5sTMwDQywwsLzKRRh",<br/>
        ///         "actorTaskId" : "W9bs9JE9v7wprjAnJ"<br/>
        ///     },<br/>
        ///     "payloadTemplate": "",<br/>
        ///     "headersTemplate": "",<br/>
        ///     "description": "my awesome webhook",<br/>
        ///     "shouldInterpolateStrings": false,<br/>
        /// ```<br/>
        /// **Important**: The request must specify the `Content-Type: application/json`<br/>
        /// HTTP header.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.AutoSDKHttpResponse<global::Apify.WebhookResponse>> WebhooksPostAsResponseAsync(

            global::Apify.WebhookCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create webhook<br/>
        /// Creates a new webhook with settings provided by the webhook object passed as<br/>
        /// JSON in the payload.<br/>
        /// The response is the created webhook object.<br/>
        /// To avoid duplicating a webhook, use the `idempotencyKey` parameter in the<br/>
        /// request body.<br/>
        /// Multiple calls to create a webhook with the same `idempotencyKey` will only<br/>
        /// create the webhook with the first call and return the existing webhook on<br/>
        /// subsequent calls.<br/>
        /// Idempotency keys must be unique, so use a UUID or another random string with<br/>
        /// enough entropy.<br/>
        /// To assign the new webhook to an Actor or task, the request body must contain<br/>
        /// `requestUrl`, `eventTypes`, and `condition` properties.<br/>
        /// * `requestUrl` is the webhook's target URL, to which data is sent as a POST<br/>
        /// request with a JSON payload.<br/>
        /// * `eventTypes` is a list of events that will trigger the webhook, e.g. when<br/>
        /// the Actor run succeeds.<br/>
        /// * `condition` should be an object containing the ID of the Actor or task to<br/>
        /// which the webhook will be assigned.<br/>
        /// * `payloadTemplate` is a JSON-like string, whose syntax is extended with the<br/>
        /// use of variables.<br/>
        /// * `headersTemplate` is a JSON-like string, whose syntax is extended with the<br/>
        /// use of variables. Following values will be re-written to defaults: "host",<br/>
        /// "Content-Type", "X-Apify-Webhook", "X-Apify-Webhook-Dispatch-Id",<br/>
        /// "X-Apify-Request-Origin"<br/>
        /// * `description` is an optional string.<br/>
        /// * `shouldInterpolateStrings` is a boolean indicating whether to interpolate<br/>
        /// variables contained inside strings in the `payloadTemplate`<br/>
        /// ```<br/>
        ///     "isAdHoc" : false,<br/>
        ///     "requestUrl" : "https://example.com",<br/>
        ///     "eventTypes" : [<br/>
        ///         "ACTOR.RUN.SUCCEEDED",<br/>
        ///         "ACTOR.RUN.ABORTED"<br/>
        ///     ],<br/>
        ///     "condition" : {<br/>
        ///         "actorId": "5sTMwDQywwsLzKRRh",<br/>
        ///         "actorTaskId" : "W9bs9JE9v7wprjAnJ"<br/>
        ///     },<br/>
        ///     "payloadTemplate": "",<br/>
        ///     "headersTemplate": "",<br/>
        ///     "description": "my awesome webhook",<br/>
        ///     "shouldInterpolateStrings": false,<br/>
        /// ```<br/>
        /// **Important**: The request must specify the `Content-Type: application/json`<br/>
        /// HTTP header.
        /// </summary>
        /// <param name="isAdHoc"></param>
        /// <param name="eventTypes"></param>
        /// <param name="condition"></param>
        /// <param name="idempotencyKey"></param>
        /// <param name="ignoreSslErrors"></param>
        /// <param name="doNotRetry"></param>
        /// <param name="requestUrl"></param>
        /// <param name="payloadTemplate"></param>
        /// <param name="headersTemplate"></param>
        /// <param name="description"></param>
        /// <param name="shouldInterpolateStrings"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Apify.WebhookResponse> WebhooksPostAsync(
            global::System.Collections.Generic.IList<global::Apify.WebhookEventType> eventTypes,
            global::Apify.WebhookCondition condition,
            string requestUrl,
            bool? isAdHoc = default,
            string? idempotencyKey = default,
            bool? ignoreSslErrors = default,
            bool? doNotRetry = default,
            string? payloadTemplate = default,
            string? headersTemplate = default,
            string? description = default,
            bool? shouldInterpolateStrings = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}