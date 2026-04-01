
#nullable enable

namespace Apify
{
    public partial class ActorTasksClient
    {
        partial void PrepareActorTaskRunsPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string actorTaskId,
            ref double? timeout,
            ref double? memory,
            ref double? maxItems,
            ref double? maxTotalChargeUsd,
            ref bool? restartOnError,
            ref string? build,
            ref double? waitForFinish,
            ref string? webhooks,
            object request);
        partial void PrepareActorTaskRunsPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string actorTaskId,
            double? timeout,
            double? memory,
            double? maxItems,
            double? maxTotalChargeUsd,
            bool? restartOnError,
            string? build,
            double? waitForFinish,
            string? webhooks,
            object request);
        partial void ProcessActorTaskRunsPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessActorTaskRunsPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Run task<br/>
        /// Runs an Actor task and immediately returns without waiting for the run to<br/>
        /// finish.<br/>
        /// Optionally, you can override the Actor input configuration by passing a JSON<br/>
        /// object as the POST payload and setting the `Content-Type: application/json` HTTP header.<br/>
        /// Note that if the object in the POST payload does not define a particular<br/>
        /// input property, the Actor run uses the default value defined by the task (or Actor's input<br/>
        /// schema if not defined by the task).<br/>
        /// The response is the Actor Run object as returned by the [Get<br/>
        /// run](#/reference/actor-runs/run-object-and-its-storages/get-run) endpoint.<br/>
        /// If you want to wait for the run to finish and receive the actual output of<br/>
        /// the Actor run as the response, use one of the [Run task<br/>
        /// synchronously](#/reference/actor-tasks/run-task-synchronously) API endpoints<br/>
        /// instead.<br/>
        /// To fetch the Actor run results that are typically stored in the default<br/>
        /// dataset, you'll need to pass the ID received in the `defaultDatasetId` field<br/>
        /// received in the response JSON to the<br/>
        /// [Get dataset items](#/reference/datasets/item-collection/get-items) API endpoint.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="timeout">
        /// Example: 60
        /// </param>
        /// <param name="memory">
        /// Example: 256
        /// </param>
        /// <param name="maxItems">
        /// Example: 1000
        /// </param>
        /// <param name="maxTotalChargeUsd">
        /// Example: 5
        /// </param>
        /// <param name="restartOnError">
        /// Example: false
        /// </param>
        /// <param name="build">
        /// Example: 0.1.234
        /// </param>
        /// <param name="waitForFinish">
        /// Example: 60
        /// </param>
        /// <param name="webhooks">
        /// Example: dGhpcyBpcyBqdXN0IGV4YW1wbGUK...
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Apify.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Apify.ActorTaskRunsPostResponse> ActorTaskRunsPostAsync(
            string actorTaskId,

            object request,
            double? timeout = default,
            double? memory = default,
            double? maxItems = default,
            double? maxTotalChargeUsd = default,
            bool? restartOnError = default,
            string? build = default,
            double? waitForFinish = default,
            string? webhooks = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareActorTaskRunsPostArguments(
                httpClient: HttpClient,
                actorTaskId: ref actorTaskId,
                timeout: ref timeout,
                memory: ref memory,
                maxItems: ref maxItems,
                maxTotalChargeUsd: ref maxTotalChargeUsd,
                restartOnError: ref restartOnError,
                build: ref build,
                waitForFinish: ref waitForFinish,
                webhooks: ref webhooks,
                request: request);

            var __pathBuilder = new global::Apify.PathBuilder(
                path: $"/v2/actor-tasks/{actorTaskId}/runs",
                baseUri: HttpClient.BaseAddress);
            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Query")
                {
                    __pathBuilder = __pathBuilder.AddRequiredParameter(__authorization.Name, __authorization.Value);
                }
            } 
            __pathBuilder
                .AddOptionalParameter("timeout", timeout?.ToString())
                .AddOptionalParameter("memory", memory?.ToString())
                .AddOptionalParameter("maxItems", maxItems?.ToString())
                .AddOptionalParameter("maxTotalChargeUsd", maxTotalChargeUsd?.ToString())
                .AddOptionalParameter("restartOnError", restartOnError?.ToString().ToLowerInvariant())
                .AddOptionalParameter("build", build)
                .AddOptionalParameter("waitForFinish", waitForFinish?.ToString())
                .AddOptionalParameter("webhooks", webhooks) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareActorTaskRunsPostRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                actorTaskId: actorTaskId,
                timeout: timeout,
                memory: memory,
                maxItems: maxItems,
                maxTotalChargeUsd: maxTotalChargeUsd,
                restartOnError: restartOnError,
                build: build,
                waitForFinish: waitForFinish,
                webhooks: webhooks,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessActorTaskRunsPostResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Bad request - invalid input parameters or request body.
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::Apify.ErrorResponse? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::Apify.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::Apify.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::Apify.ApiException<global::Apify.ErrorResponse>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Unauthorized - authentication required or invalid token.
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::Apify.ErrorResponse? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::Apify.ErrorResponse.FromJson(__content_401, JsonSerializerContext);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::Apify.ErrorResponse.FromJson(__content_401, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::Apify.ApiException<global::Apify.ErrorResponse>(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseObject = __value_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Forbidden - insufficient permissions to perform this action.
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                global::Apify.ErrorResponse? __value_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_403 = global::Apify.ErrorResponse.FromJson(__content_403, JsonSerializerContext);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_403 = global::Apify.ErrorResponse.FromJson(__content_403, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::Apify.ApiException<global::Apify.ErrorResponse>(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseObject = __value_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Not found - the requested resource does not exist.
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                global::Apify.ErrorResponse? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::Apify.ErrorResponse.FromJson(__content_404, JsonSerializerContext);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_404 = global::Apify.ErrorResponse.FromJson(__content_404, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::Apify.ApiException<global::Apify.ErrorResponse>(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Method not allowed.
            if ((int)__response.StatusCode == 405)
            {
                string? __content_405 = null;
                global::System.Exception? __exception_405 = null;
                global::Apify.ErrorResponse? __value_405 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_405 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_405 = global::Apify.ErrorResponse.FromJson(__content_405, JsonSerializerContext);
                    }
                    else
                    {
                        __content_405 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_405 = global::Apify.ErrorResponse.FromJson(__content_405, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_405 = __ex;
                }

                throw new global::Apify.ApiException<global::Apify.ErrorResponse>(
                    message: __content_405 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_405,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_405,
                    ResponseObject = __value_405,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Payload too large - the request body exceeds the size limit.
            if ((int)__response.StatusCode == 413)
            {
                string? __content_413 = null;
                global::System.Exception? __exception_413 = null;
                global::Apify.ErrorResponse? __value_413 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_413 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_413 = global::Apify.ErrorResponse.FromJson(__content_413, JsonSerializerContext);
                    }
                    else
                    {
                        __content_413 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_413 = global::Apify.ErrorResponse.FromJson(__content_413, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_413 = __ex;
                }

                throw new global::Apify.ApiException<global::Apify.ErrorResponse>(
                    message: __content_413 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_413,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_413,
                    ResponseObject = __value_413,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Unsupported media type - the Content-Encoding of the request is not supported.
            if ((int)__response.StatusCode == 415)
            {
                string? __content_415 = null;
                global::System.Exception? __exception_415 = null;
                global::Apify.ErrorResponse? __value_415 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_415 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_415 = global::Apify.ErrorResponse.FromJson(__content_415, JsonSerializerContext);
                    }
                    else
                    {
                        __content_415 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_415 = global::Apify.ErrorResponse.FromJson(__content_415, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_415 = __ex;
                }

                throw new global::Apify.ApiException<global::Apify.ErrorResponse>(
                    message: __content_415 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_415,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_415,
                    ResponseObject = __value_415,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Too many requests - rate limit exceeded.
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::System.Exception? __exception_429 = null;
                global::Apify.ErrorResponse? __value_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_429 = global::Apify.ErrorResponse.FromJson(__content_429, JsonSerializerContext);
                    }
                    else
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_429 = global::Apify.ErrorResponse.FromJson(__content_429, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::Apify.ApiException<global::Apify.ErrorResponse>(
                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_429,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
                    ResponseObject = __value_429,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessActorTaskRunsPostResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Apify.ActorTaskRunsPostResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Apify.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Apify.ActorTaskRunsPostResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Apify.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Run task<br/>
        /// Runs an Actor task and immediately returns without waiting for the run to<br/>
        /// finish.<br/>
        /// Optionally, you can override the Actor input configuration by passing a JSON<br/>
        /// object as the POST payload and setting the `Content-Type: application/json` HTTP header.<br/>
        /// Note that if the object in the POST payload does not define a particular<br/>
        /// input property, the Actor run uses the default value defined by the task (or Actor's input<br/>
        /// schema if not defined by the task).<br/>
        /// The response is the Actor Run object as returned by the [Get<br/>
        /// run](#/reference/actor-runs/run-object-and-its-storages/get-run) endpoint.<br/>
        /// If you want to wait for the run to finish and receive the actual output of<br/>
        /// the Actor run as the response, use one of the [Run task<br/>
        /// synchronously](#/reference/actor-tasks/run-task-synchronously) API endpoints<br/>
        /// instead.<br/>
        /// To fetch the Actor run results that are typically stored in the default<br/>
        /// dataset, you'll need to pass the ID received in the `defaultDatasetId` field<br/>
        /// received in the response JSON to the<br/>
        /// [Get dataset items](#/reference/datasets/item-collection/get-items) API endpoint.
        /// </summary>
        /// <param name="actorTaskId">
        /// Example: janedoe~my-task
        /// </param>
        /// <param name="timeout">
        /// Example: 60
        /// </param>
        /// <param name="memory">
        /// Example: 256
        /// </param>
        /// <param name="maxItems">
        /// Example: 1000
        /// </param>
        /// <param name="maxTotalChargeUsd">
        /// Example: 5
        /// </param>
        /// <param name="restartOnError">
        /// Example: false
        /// </param>
        /// <param name="build">
        /// Example: 0.1.234
        /// </param>
        /// <param name="waitForFinish">
        /// Example: 60
        /// </param>
        /// <param name="webhooks">
        /// Example: dGhpcyBpcyBqdXN0IGV4YW1wbGUK...
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Apify.ActorTaskRunsPostResponse> ActorTaskRunsPostAsync(
            string actorTaskId,
            double? timeout = default,
            double? memory = default,
            double? maxItems = default,
            double? maxTotalChargeUsd = default,
            bool? restartOnError = default,
            string? build = default,
            double? waitForFinish = default,
            string? webhooks = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __request = new object
            {
            };

            return await ActorTaskRunsPostAsync(
                actorTaskId: actorTaskId,
                timeout: timeout,
                memory: memory,
                maxItems: maxItems,
                maxTotalChargeUsd: maxTotalChargeUsd,
                restartOnError: restartOnError,
                build: build,
                waitForFinish: waitForFinish,
                webhooks: webhooks,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}